using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using GerenciadorDeEstoque.Models;

namespace GerenciadorDeEstoque.Controllers;

public class HomeController : Controller
{
    // A��o que carrega a p�gina inicial
    public IActionResult Index() {
        ViewData["Title"] = "Home Page";
        return View();
    }

    // A��o que processa o envio do formul�rio de registro de produtos
    [HttpPost]
    public IActionResult RegistrarProduto(string nomeProduto, int quantProduto, decimal precoProduto, string grupoProduto) {
        // L�gica para processar os dados do produto
        if (string.IsNullOrEmpty(nomeProduto) || quantProduto <= 0 || precoProduto <= 0) {
            // Se houver um erro de valida��o, retorna uma mensagem de erro
            ViewData["Message"] = "Por favor, preencha todos os campos corretamente.";
            return View("Index");
        }

        // Aqui vou salvar os dados em um banco de dados, por exemplo
        // var novoProduto = new Produto { Nome = nomeProduto, Quantidade = quantProduto, Preco = precoProduto, Grupo = grupoProduto };
        // _context.Produtos.Add(novoProduto);
        // _context.SaveChanges();

        // Retorna uma mensagem de sucesso
        ViewData["Message"] = "Produto registrado com sucesso!";
        return View("Index");
    }
}
