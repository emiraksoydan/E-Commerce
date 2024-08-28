using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstract;
using Business.Concrete;
using Castle.DynamicProxy;
using Core.Interceptors;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {


            builder.RegisterType<CategoryManager>().As<ICategoryService>().SingleInstance();
            builder.RegisterType<CategorieDal>().As<ICategoryDal>().SingleInstance();

            builder.RegisterType<AddressManager>().As<IAddressService>().SingleInstance();
            builder.RegisterType<AddressDal>().As<IAdressDal>().SingleInstance();

            builder.RegisterType<CartItemDal>().As<ICartItem>().SingleInstance();
            builder.RegisterType<CartItemManager>().As<ICartItemsService>().SingleInstance();

            //builder.RegisterType<CartDal>().As<ICartDal>().SingleInstance();
            //builder.RegisterType<CartManager>().As<ICartService>().SingleInstance();

            builder.RegisterType<OrderItemDal>().As<IOrderItemDal>().SingleInstance();
            builder.RegisterType<OrderItemManager>().As<IOrderItemService>().SingleInstance();

            builder.RegisterType<OrderDal>().As<IOrderDal>().SingleInstance();
            builder.RegisterType<OrderManager>().As<IOrderService>().SingleInstance();

            builder.RegisterType<ProductAttributesDal>().As<IProductAttributeDal>().SingleInstance();
            builder.RegisterType<ProductAttributeManager>().As<IProductAttribute>().SingleInstance();

            builder.RegisterType<ProductDal>().As<IProductDal>().SingleInstance();
            builder.RegisterType<ProductManager>().As<IProductService>().SingleInstance();

            builder.RegisterType<StockManager>().As<IStockService>().SingleInstance();
            builder.RegisterType<StockDal>().As<IStockDal>().SingleInstance();

            builder.RegisterType<WishListManager>().As<IWishListService>().SingleInstance();
            builder.RegisterType<WishListDal>().As<IWishList>().SingleInstance();





            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();

        }
    }
}
