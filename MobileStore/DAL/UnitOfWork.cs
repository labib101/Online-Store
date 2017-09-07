using MobileStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MobileStore.DAL
{
    //The one with all the general repositories
    public partial class UnitOfWork : IDisposable
    {
        private StoreDbContext ctx = new StoreDbContext();

        private GenericRepository<Product> productRepository;
        private GenericRepository<Productdetail> productDetailRepository;
        private GenericRepository<Customer> customerRepository;
        private GenericRepository<Sales> salesRepository;
        private GenericRepository<LoginAuthentications> loginAuthenticationRepository;
        private GenericRepository<Organisation> organisationRepository;
        private GenericRepository<Category> categoryRepository;
        private GenericRepository<SubCategory> subCategoryRepository;
        private GenericRepository<Admins> adminsRepository;

        public GenericRepository<Admins> AdminsRepository
        {
            get
            {

                if (this.adminsRepository == null)
                {
                    this.adminsRepository = new GenericRepository<Admins>(ctx);
                }
                return adminsRepository;

            }
        }

        public GenericRepository<Product> ProductRepository
        {
            get
            {

                if (this.productRepository == null)
                {
                    this.productRepository = new GenericRepository<Product>(ctx);
                }
                return productRepository;

            }
        }

        public GenericRepository<Productdetail> ProductDetailRepository
        {
            get
            {

                if (this.productDetailRepository == null)
                {
                    this.productDetailRepository = new GenericRepository<Productdetail>(ctx);
                }
                return productDetailRepository;

            }
        }

        public GenericRepository<Customer> CustomerRepository
        {
            get
            {

                if (this.customerRepository == null)
                {
                    this.customerRepository = new GenericRepository<Customer>(ctx);
                }
                return customerRepository;

            }
        }

        public GenericRepository<Sales> SalesRepository
        {
            get
            {

                if (this.salesRepository == null)
                {
                    this.salesRepository = new GenericRepository<Sales>(ctx);
                }
                return salesRepository;

            }
        }

        public GenericRepository<LoginAuthentications> LoginAuthenticationRepository
        {
            get
            {

                if (this.loginAuthenticationRepository == null)
                {
                    this.loginAuthenticationRepository = new GenericRepository<LoginAuthentications>(ctx);
                }
                return loginAuthenticationRepository;

            }
        }

        public GenericRepository<Organisation> OrganisationRepository
        {
            get
            {

                if (this.organisationRepository == null)
                {
                    this.organisationRepository = new GenericRepository<Organisation>(ctx);
                }
                return organisationRepository;

            }
        }

        public GenericRepository<Category> CategoryRepository
        {
            get
            {

                if (this.categoryRepository == null)
                {
                    this.categoryRepository = new GenericRepository<Category>(ctx);
                }
                return categoryRepository;

            }
        }

        public GenericRepository<SubCategory> SubCategoryRepository
        {
            get
            {

                if (this.subCategoryRepository == null)
                {
                    this.subCategoryRepository = new GenericRepository<SubCategory>(ctx);
                }
                return subCategoryRepository;

            }
        }

        public void Save()
        {
            ctx.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    ctx.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }

    //the one with the specified works
    public partial class UnitOfWork
    {
        public void SetProductView(int id)
        {
            Product product = ProductRepository.GetByID(id);
            SetProductView(product);

        }

        public void SetProductView(Product product)
        {
            product.ProductView = product.ProductView + 1;
            ProductRepository.Update(product);
            Save();
        }
    }
}