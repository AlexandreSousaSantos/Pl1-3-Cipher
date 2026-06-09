using Projeto_iShopping.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Projeto_iShopping.Controller
{
    // Controlador para gerir operações de artigos
    public class ArtigoController
    {
        // Lista todos os artigos ordenados por nome
        public static List<Artigo> ListarTodos()
        {
            using (iShoppingContext db = new iShoppingContext())
            {
                return db.Artigos.Include("TipoArtigo").OrderBy(a => a.NomeArtigo).ToList();
            }
        }

        // Lista artigos por tipo
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

        // Obter artigo por ID
        public static Artigo ObterPorId(int id)
        {
            using (iShoppingContext db = new iShoppingContext())
            {
                return db.Artigos.Include("TipoArtigo").FirstOrDefault(a => a.Id == id);
            }
        }

        // Criar novo artigo
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

        // Atualizar artigo existente
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

        // Eliminar artigo (remove itens relacionados primeiro)
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
