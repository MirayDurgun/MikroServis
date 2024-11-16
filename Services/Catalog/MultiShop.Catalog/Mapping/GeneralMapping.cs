﻿using AutoMapper;
using MultiShop.Catalog.Dtos.CategoryDtos;
using MultiShop.Catalog.Dtos.ProductDetailDtos;
using MultiShop.Catalog.Dtos.ProductDtos;
using MultiShop.Catalog.Dtos.ProductImageDtos;
using MultiShop.Catalog.Entities;

namespace MultiShop.Catalog.Mapping
{
	public class GeneralMapping:Profile
	{
		public GeneralMapping() {
		
			CreateMap<Category,ResultCategoryDto>().ReverseMap(); //categori sınıfı ile dto maple eşle
			CreateMap<Category,CreateCategoryDto>().ReverseMap(); 
			CreateMap<Category,UpdateCategoryDto>().ReverseMap(); 
			CreateMap<Category,GetByIdCategoryDto>().ReverseMap(); 

			CreateMap<Product,ResultProductDto>().ReverseMap(); 
			CreateMap<Product,CreateProductDto>().ReverseMap(); 
			CreateMap<Product,UpdateProductDto>().ReverseMap(); 
			CreateMap<Product,GetByIdProductDto>().ReverseMap(); 

			CreateMap<ProductDetail,ResultProductDetailDto>().ReverseMap(); 
			CreateMap<ProductDetail,CreateProductDetailDto>().ReverseMap(); 
			CreateMap<ProductDetail,UpdateProductDetailDto>().ReverseMap(); 
			CreateMap<ProductDetail,GetByIdProductDetailDto>().ReverseMap(); 

			CreateMap<ProductsImage,ResultProductImageDto>().ReverseMap(); 
			CreateMap<ProductsImage,CreateProducImageDto>().ReverseMap(); 
			CreateMap<ProductsImage,UpdateProductImageDto>().ReverseMap(); 
			CreateMap<ProductsImage,GetByIdProductImageDto>().ReverseMap(); 
		}
	}
}
