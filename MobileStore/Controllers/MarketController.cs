using MobileStore.DAL;
using MobileStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MobileStore.Controllers
{
    [RoutePrefix("api/Market")]
    public class MarketController : ApiController
    {
        private UnitOfWork unitOfWork = new UnitOfWork();
        private StoreDbContext ctx = new StoreDbContext();

        [HttpGet]
        [ActionName("getSelectedProduct")]
        public Product getSelectedProduct(int id)
        {
            unitOfWork.SetProductView(id);
            return unitOfWork.ProductRepository.GetByID(id);
        }

        [HttpGet]
        [ActionName("getSelectedProductDetails")]
        public Productdetail getSelectedProductDetails(int id) { return unitOfWork.ProductDetailRepository.GetByID(id); }

        [HttpGet]
        [ActionName("getAllProducts")]
        public IEnumerable<Product> getAllProducts() { return unitOfWork.ProductRepository.Get(); }

        [HttpGet]
        [ActionName("getOrganisationList")]
        public IEnumerable<Organisation> getOrganisationList() { return unitOfWork.OrganisationRepository.Get(); }

        [HttpGet]
        [ActionName("getAllSellers")]
        public IEnumerable<Customer> getAllSellers() { return unitOfWork.CustomerRepository.Get(); }

        [HttpGet]
        [ActionName("getPremiumAds")]
        public IEnumerable<Product> getPremiumAds() { return unitOfWork.ProductRepository.Get(filter: x=> x.IsPremium==1); }

        [HttpGet]
        [ActionName("getCategoryList")]
        public IEnumerable<Category> getCategoryList() { return unitOfWork.CategoryRepository.Get(); }

        [HttpGet]
        [ActionName("getSubCategoryList")]
        public IEnumerable<SubCategory> getSubCategoryList() { return unitOfWork.SubCategoryRepository.Get(); }

        protected override void Dispose(bool disposing)
        {
            unitOfWork.Dispose();
            base.Dispose(disposing);
        }
    }
}
