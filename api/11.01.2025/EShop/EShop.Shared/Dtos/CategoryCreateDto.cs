using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;


namespace EShop.Shared.Dtos;

public class CategoryCreateDto
{
    [Required(ErrorMessage = "Kategori ado zorunludur!")]
    [StringLength(100, ErrorMessage = "Kategori adı en fazla 100 karakter olmalıdır!")]
    public string? Name { get; set; }

    [StringLength(500, ErrorMessage = "Açıklama en fazla 500 karakter olmalıdır!")]
    public string? Description { get; set; }

    [Required(ErrorMessage = "Kategori resmi zorunludur!")]
    public IFormFile? Image { get; set; }
}