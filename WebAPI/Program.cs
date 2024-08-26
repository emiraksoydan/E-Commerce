using Autofac;
using Autofac.Extensions.DependencyInjection;
using Business.Abstract;
using Business.Concrete;
using Business.DependencyResolvers.Autofac;
using Core.EfCore;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory()).ConfigureContainer<ContainerBuilder>(container => { container.RegisterModule(new AutofacBusinessModule());});

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<DbConnection>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DbConnecttion"));
});

//builder.Services.AddScoped<ICartService, CartManager>();
//builder.Services.AddScoped<ICartItemsService, CartItemManager>();
//builder.Services.AddScoped<IWishListService,WishListManager>();
//builder.Services.AddScoped<IProductService, ProductManager>();
//builder.Services.AddScoped<IProductAttribute, ProductAttributeManager>();
//builder.Services.AddScoped<IStockService, StockManager>();
//builder.Services.AddScoped<IAddressService, AddressManager>();
//builder.Services.AddScoped<IOrderService, OrderManager>();
//builder.Services.AddScoped<IOrderItemService, OrderItemManager>();
//builder.Services.AddScoped<ICategoryService, CategoryManager>();


//builder.Services.AddScoped<ICartDal, CartDal>();
//builder.Services.AddScoped<ICartItem, CartItemDal>();
//builder.Services.AddScoped<IProductDal, ProductDal>();
//builder.Services.AddScoped<IProductAttributeDal, ProductAttributesDal>();
//builder.Services.AddScoped<IStockDal, StockDal>();
//builder.Services.AddScoped<IAdressDal, AddressDal>();
//builder.Services.AddScoped<IOrderDal, OrderDal>();
//builder.Services.AddScoped<IWishList, WishListDal>();
//builder.Services.AddScoped<IOrderItemDal, OrderItemDal>();
//builder.Services.AddScoped<ICategoryDal, CategorieDal>();




var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<DbConnection>();
    if (!dbContext.Database.CanConnect())
    {
        throw new NotImplementedException("Can not connect DB");
    }
}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
