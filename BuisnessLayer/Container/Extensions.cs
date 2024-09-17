using BuisnessLayer.Abstract;
using BuisnessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessLayer.Container
{
    public static class Extensions
    {

        public static void ContainerDependencies(this IServiceCollection services)
        {
            services.AddControllersWithViews();

            services.AddDbContext<Context>();

            services.AddScoped<ICommentService, CommentManager>();
            services.AddScoped<ICommentDal, EfCommentDal>();

            services.AddScoped<IDestinationService, DestinationManager>();
            services.AddScoped<IDestinationDal, EfDestinationDal>();

            services.AddScoped<IAppUserService, AppUserManager>();
            services.AddScoped<IAppUserDal, EfAppUserDal>();

            services.AddScoped<IReservationService, ReservationManager>();
            services.AddScoped<IReservationDal, EfReservationDal>();


            services.AddIdentity<AppUser, AppRole>()
      .AddEntityFrameworkStores<Context>();


        }
    }
}
