﻿using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ProductsService.Models;
using ProductsService.Repositories;

namespace ProductsService.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class ProductsController : ControllerBase
  {
    private readonly IProductRepository _productRepository;

    public ProductsController(IProductRepository productRepository)
    {
      _productRepository = productRepository;
    }
    
    [HttpGet]
    public IEnumerable<Product> Get() => _productRepository.FindAll();

    [HttpPost]
    public Product Post([FromBody] Product product)
    {
      _productRepository.Create(product);
      return product;
    } 
  }
}
