using Projeto_iShopping.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_iShopping.Controller
{
    public class ArtigoController
    {
        public static List<Artigo> ListarTodos()
        {
            using (iShoppingContext db = new iShoppingContext())
            {
                return db.Artigos.Include("TipoArtigo").OrderBy(a => a.NomeArtigo).ToList();
            }
        }

        public static List<Artigo> ListarPorTipo(int tipoArtigoId)
        {
            using (iShoppingContext db = new iShoppingContext())
            {
                return db.Artigos.Include("TipoArtigo")
                    .Where(a => a.TipoArtigoId == tipoArtigoId)
                    .OrderBy(a => a.NomeArtigo)
                    .ToList();
            }
        }
        //obter artigo por id
        public static Artigo ObterPorId(int id)
        {
            using (iShoppingContext db = new iShoppingContext())
            {
                // Include("TipoArtigo") para carregar os dados do tipo de artigo relacionado
                return db.Artigos.Include("TipoArtigo").FirstOrDefault(a => a.Id == id);
            }
        }
        public static void Criar(string nomeArtigo, int tipoArtigoId)
        {
            if (string.IsNullOrWhiteSpace(nomeArtigo))
            {
                throw new Exception("Nome do artigo obrigatório.");
            }

            using (iShoppingContext db = new iShoppingContext())
            {
                Artigo novo = new Artigo
                {
                    NomeArtigo = nomeArtigo.Trim(),
                    TipoArtigoId = tipoArtigoId
                };
                db.Artigos.Add(novo);
                db.SaveChanges();
            }
        }
        public static void Atualizar(int id, string nomeArtigo, int tipoArtigoId)
        {
            if (string.IsNullOrWhiteSpace(nomeArtigo))
            {
                throw new Exception("Nome do artigo obrigatório.");
            }

            using (iShoppingContext db = new iShoppingContext())
            {
                Artigo artigo = db.Artigos.Find(id);
                if (artigo == null)
                {
                    throw new Exception("Artigo não encontrado.");
                }

                artigo.NomeArtigo = nomeArtigo.Trim();
                artigo.TipoArtigoId = tipoArtigoId;
                db.SaveChanges();
            }
        }
       
        public static void Eliminar(int id)
        {
            using (iShoppingContext db = new iShoppingContext())
            {
                Artigo artigo = db.Artigos.Find(id);
                if (artigo == null)
                {
                    throw new Exception("Artigo não encontrado.");
                }
                var itens = db.ItemCompra.Where(i => i.ArtigoId == id).ToList();
                foreach (var item in itens)
                {
                    db.ItemCompra.Remove(item);
                }
                db.Artigos.Remove(artigo);
                db.SaveChanges();
            }
        }
    }
}
