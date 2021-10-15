using Application.Interfaces;
using Application.Model;
using AutoMapper;
using Domain.Interfaces.InterfaceProduct;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Application.OpenApp
{
    public class ServiceProduct : InterfaceAppProduct
    {
        IProduct IProduct;
        protected readonly IMapper _mapper;
        public ServiceProduct(IProduct IProduct, IMapper _mapper)
        {
            this.IProduct = IProduct;
            this._mapper = _mapper;
        }
        public async Task Add(ProductModel product)
        {
            var entidade = _mapper.Map<Product>(product);

            var validName = entidade.ValidarPropriedadeString(product.Name, "Name");
            var validprice = entidade.ValidarPropriedadeDecimal(product.Price, "Price");

            if(validName && validprice)
            {                
                product.Rented = true;
                product.DateCreate = DateTime.UtcNow;
                product.DateEdit = DateTime.UtcNow;
                await IProduct.Add(entidade);
            }
                
        }

        public async Task Delete(ProductModel Object)
        {
            var entidade = _mapper.Map<Product>(Object);

            await IProduct.Delete(entidade);
        }

        public async Task<ProductModel> GetEntityById(int Id)
        {
            var entidade = await this.IProduct.GetEntityById(Id);
            return _mapper.Map<ProductModel>(entidade);
        }

        public async Task<List<ProductModel>> List()
        {
            var listaEntidades = await this.IProduct.List();
            var entidade = _mapper.Map<List<ProductModel>>(listaEntidades);
            return entidade;
        }

        public async Task Update(ProductModel product)
        {
            var entidade = _mapper.Map<Product>(product);

            var validName = entidade.ValidarPropriedadeString(product.Name, "Name");
            var validprice = entidade.ValidarPropriedadeDecimal(product.Price, "Price");

            if (validName && validprice)
            {                
                await IProduct.Update(entidade);
            }
        }
    }
}
