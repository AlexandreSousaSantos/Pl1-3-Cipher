using Projeto_iShopping.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_iShopping.Controller
{
    public class TipoArtigoController
    {
        //Get do TipoArtigo
        public static List<TipoArtigo> ListarTodos()
        {
            using (iShoppingContext db = new iShoppingContext())
            {
                return db.TipoArtigo.OrderBy(d => d.Descricao).ToList();
            }
        }
        // irá preocurar e retornar o TipoArtigo com o id passado como parâmetro
        public static TipoArtigo ObterPorId(int id)
        {
            using (iShoppingContext db = new iShoppingContext())
            {
                return db.TipoArtigo.Find(id);
            }
        }
        // irá criar um novo TipoArtigo
        public static void Criar(string descricao)
        {
            if (string.IsNullOrWhiteSpace(descricao))
            {
                MessageBox.Show("Descrição obrigatória.");
                return;
            }

            // Verificar se já existe um TipoArtigo com a mesma descrição 
            using (iShoppingContext db = new iShoppingContext())
            {
                if (db.TipoArtigo.Any(t => t.Descricao == descricao.Trim()))
                {
                    MessageBox.Show("Já existe um Tipo de Artigo com esta descrição.");
                    return;
                }


                // Criar e salvar o novo TipoArtigo
                TipoArtigo novo = new TipoArtigo { Descricao = descricao.Trim() };
                db.TipoArtigo.Add(novo);
                db.SaveChanges();
            }

        }
        // irá atualizar a descrição do TipoArtigo com o id passado como parâmetro
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
                // Verificar se já existe um TipoArtigo com a nova descrição
                if (db.TipoArtigo.Any(t => t.Descricao == novaDescricao.Trim() && t.Id != id))
                {
                    MessageBox.Show("Já existe um Tipo de Artigo com esta descrição.");
                    return;
                }
                tipo.Descricao = novaDescricao.Trim();
                db.SaveChanges();
            }
        }
        // irá remover o TipoArtigo com o id passado como parâmetro
        public static void Eliminar(int id)
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
    }
}
