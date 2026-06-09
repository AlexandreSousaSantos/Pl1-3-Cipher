using Projeto_iShopping.Models;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Windows.Forms;

namespace Projeto_iShopping.Controller
{
    // Controlador para gerir operações de tipos de artigos
    public class TipoArtigoController
    {
        // Lista todos os tipos de artigos
        public static List<TipoArtigo> ListarTodos()
        {
            using (iShoppingContext db = new iShoppingContext())
            {
                return db.TipoArtigo.ToList();
            }
        }

        // Obter tipo de artigo por ID
        public static TipoArtigo ObterPorId(int id)
        {
            using (iShoppingContext db = new iShoppingContext())
            {
                return db.TipoArtigo.Find(id);
            }
        }

        // Criar novo tipo de artigo (valida duplicata)
        public static void Criar(string descricao)
        {
            if (string.IsNullOrWhiteSpace(descricao))
            {
                MessageBox.Show("Descrição obrigatória.");
                return;
            }

            using (iShoppingContext db = new iShoppingContext())
            {
                if (db.TipoArtigo.Any(t => t.Descricao == descricao.Trim()))
                {
                    MessageBox.Show("Já existe um Tipo de Artigo com esta descrição.");
                    return;
                }

                TipoArtigo novo = new TipoArtigo { Descricao = descricao.Trim() };
                db.TipoArtigo.Add(novo);
                db.SaveChanges();
            }
        }

        // Atualizar descrição do tipo de artigo
        public static void Atualizar(int id, string novaDescricao)
        {
            if (string.IsNullOrWhiteSpace(novaDescricao))
            {
                MessageBox.Show("Descrição obrigatória.");
                return;
            }
            using (iShoppingContext db = new iShoppingContext())
            {
                var tipo = db.TipoArtigo.Find(id);
                if (tipo == null)
                {
                    MessageBox.Show("Tipo de Artigo não encontrado.");
                    return;
                }

                if (db.TipoArtigo.Any(t => t.Descricao == novaDescricao.Trim() && t.Id != id))
                {
                    MessageBox.Show("Já existe um Tipo de Artigo com esta descrição.");
                    return;
                }
                tipo.Descricao = novaDescricao.Trim();
                db.SaveChanges();
            }
        }

        // Eliminar tipo de artigo
        public static void Eliminar(int id)
        {
            try
            {
                using (iShoppingContext db = new iShoppingContext())
                {
                    var tipo = db.TipoArtigo.Find(id);
                    if (tipo == null)
                    {
                        MessageBox.Show("Tipo de Artigo não encontrado.");
                        return;
                    }
                    db.TipoArtigo.Remove(tipo);
                    db.SaveChanges();
                }
            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show(ex.InnerException?.InnerException?.Message
                                ?? ex.Message);
            }
        }
    }
}

