using HPlusSport.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace HPlusSport.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {

        //criação da variável privada _shopContext
        private readonly ShopContext _shopContext;


        //o construtor recebe uma instância do ShopContext(é a classe que fornece acesso aos dados do banco de dados)
        //como parâmetro e o armazena no campo
        public ProductsController(ShopContext shopContext)
        {

            _shopContext = shopContext;

            //esse método garante que o banco de dados existe e foi criado
            _shopContext.Database.EnsureCreated();
        }


        [HttpGet]
        //O ActionResult é um tipo de retorno de um método de ação no ASP.NET MVC.
        //Ele representa o resultado de uma ação, que pode ser uma view, um arquivo, um redirecionamento, um erro, ou qualquer outra coisa.
        public async Task<ActionResult> GetAllProducts()
        {
            //retorna o método Ok (código 200) com o parametro == produtos
            //agora é possível usar a url api/products do navegador
            return Ok(await _shopContext.Products.ToArrayAsync());

        }

        [HttpGet]
        [Route("{Id}")]
        public async Task<ActionResult> GetProduct(int Id)
        {
            var product = await _shopContext.Products.FindAsync(Id);

            if (product == null)
            {
                //Se o produto não existir retornamos um erro 404
                return NotFound();
            }

            return Ok(product);
        }

        [HttpPost]
        public async Task<ActionResult<Product>> PostProduct(Product product)
        {

            //verifica se os dados de inserção estão corretor
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _shopContext.Products.Add(product);
            await _shopContext.SaveChangesAsync();


            //Esse método retorna o próprio produto criado
            return CreatedAtAction
                (
                    "GetProduct",
                    new { id = product.Id },
                    product
                );

        }

        [HttpPut("{Id}")]
        public async Task<ActionResult> PutProduct(int id, Product product)
        {
            if (id != product.Id)
            {
                return BadRequest();
            }

            _shopContext.Entry(product).State = EntityState.Modified;

            try
            {
                await _shopContext.SaveChangesAsync();
            }
            //essa exceção DbUpdateConcurrencyException é para quando duas chamadas de Api tentam alterar algo simulataneamente
            catch (DbUpdateConcurrencyException)
            {
                //se o produto já foi apagado do sistema
                if (!_shopContext.Products.Any(p => p.Id == id))
                {
                    return NotFound();
                }
                //se não foi apagado, vamos apenas lançar a excessão
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        [HttpDelete("{Id}")]
        public async Task<ActionResult> DeleteProdutct(int Id) 
        {
            var product = await _shopContext.Products.FindAsync(Id);

            if(product == null) 
            {
                return NotFound();
            }

            _shopContext.Products.Remove(product);
            await _shopContext.SaveChangesAsync();

            return Ok(product);
        }

    }
}