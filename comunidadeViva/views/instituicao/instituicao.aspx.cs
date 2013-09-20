using comunidadeViva.controller;
using comunidadeViva.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace comunidadeViva.instituicao
{
    using Models.NE;
    public partial class instituicao : System.Web.UI.Page
    {


        protected void Page_Load(object sender, EventArgs e)
        {

            //if(IsPostBack)


            String parametro = Request.QueryString["parametro"];
            String strInstituicao = Request.QueryString["idInstituicao"];


            int intIdInstituicao = Convert.ToInt32(strInstituicao);

            if (parametro == "editar")
            {

                btnCadastrar.Visible = false;

//                Ne_Instituicao Ne_Inst = new Ne_Instituicao();
 //               Ne_Inst.BuscarInstituicao(intIdInstituicao);

                //lblRetorno.Text = strInstituicao;

                
                {

                    NE_Instituicao ne = new NE_Instituicao();
                    Instituicao item = ne.findById(intIdInstituicao);
                                        
                        tbxIdInstituicao.Text = Convert.ToString(item.IdInstituicao);
                        txbInstituicao.Text = item.RazaoSocial;
                        txtFantasia.Text = item.NomeFantasia;
                        txtCnpj.Text = item.CNPJ;
                        txbDescricao.Value = item.Descricao;

                        foreach (Endereco end in item.Enderecoes)
                        {

                            tbxCep.Text = end.Cep;
                            tbxLogradouro.Text = end.Logradouro;
                            tbxNumero.Text = end.Numero;
                            tbcComplemento.Text = end.Complemento;
                            //tbxBairro.Text = end.Bairro;
                            tbxCidade.Text = end.Cidade;
                            //tbxEstado.Text = end.Estado;
                            tbxReferencia.Value = end.PontoReferencia;
                            LinkMapa.Text = end.LinkMapa;

                        }

                        foreach (Contato contato in item.Contatoes)
                        {

                            tbxNome.Text = contato.Nome;
                            tbxTelefone.Text = contato.Fixo;
                            tbxCelular.Text = contato.Celular;
                            tbxEmail.Text = contato.Email;


                        }

                    
                }

            }
            else {

                btnAlterar.Visible = false;
            }
        }




        protected void CadastrarInstituicao(object sender, EventArgs e)
        {


                //Recupera os dados e carrega o objeto objInstituicao
                Instituicao objInstituicao = new Instituicao();
                objInstituicao.CNPJ = txtCnpj.Text;
                objInstituicao.RazaoSocial = txbInstituicao.Text;
                objInstituicao.NomeFantasia = txtFantasia.Text;
                objInstituicao.Descricao = txbDescricao.Value;

                //Recupera os dados e carrega o objeto objEndereco
                Endereco objEndereco = new Endereco();
                objEndereco.Cep = tbxCep.Text.Replace("-", "");
                objEndereco.Logradouro = tbxLogradouro.Text;
                objEndereco.Numero = tbxNumero.Text;
                objEndereco.Complemento = tbcComplemento.Text;
                //objEndereco.Bairro = tbxBairro.Text;
                objEndereco.Cidade = tbxCidade.Text;
                //objEndereco.Estado = tbxEstado.Text;
                objEndereco.PontoReferencia = tbxReferencia.Value;
                objEndereco.LinkMapa = LinkMapa.Text;

                //Recupera os dados e carrega o objeto objEndereco
                Contato objContato = new Contato();
                objContato.Nome = tbxNome.Text;
                objContato.Fixo = tbxTelefone.Text;
                objContato.Celular = tbxCelular.Text;
                objContato.Email = tbxEmail.Text;

                //Adiciona os objetos no contexto e salva no Banco
                objInstituicao.Contatoes.Add(objContato);
                objInstituicao.Enderecoes.Add(objEndereco);

                Ne_Instituicaos Ne_Inst = new Ne_Instituicaos();
                Ne_Inst.GravarInstituicao(objInstituicao);
                 
            }



        protected void AlterarInstituicao(object sender, EventArgs e)
        {

            using (DbComunicadaVivaContext contexto = new DbComunicadaVivaContext())
            {
                // seleciona um Instituição especifico na lista de Instituições
                Instituicao instituicao = (from InstituicaoX in contexto.Instituicaos
                               where InstituicaoX.IdInstituicao == 17
                                           select InstituicaoX).First();

                // altera o RazaoSocial da Instituição
                instituicao.RazaoSocial = "Teste instituição";//txbInstituicao.Text;
                // salva as alterações
                contexto.SaveChanges();

            }


        }




        protected void btnVoltar_Click(object sender, EventArgs e)
        {
            Response.Redirect("listaInstituicao.aspx");
        }
    }
}


/*Exemplo de crud
 
// selecionar
2
Aluno aluno;
3
using (DBEntities contexto = new DBEntities())
4
{
5
    // seleciona um aluno especifico na lista de alunos
6
    aluno = (from alunoX in contexto.Aluno
7
              where alunoX.Nome == "João Felipe Portela"
8
              select alunoX);
9
}
01
// inserir
02
using (DBEntities contexto = new DBEntities())
03
{
04
    // cria aluno define um novo objeto aluno
05
    Aluno aluno = new Aluno() { Nome = "João Felipe Portela" };
06
 
07
    // adiciona a lista de alunos
08
    contexto.AddToAluno(aluno);
09
 
10
    // salva as alterações
11
    contexto.SaveChanges();
12
}
01
// atualizar
02
using (DBEntities contexto = new DBEntities())
03
{
04
    // seleciona um aluno especifico na lista de alunos
05
    Aluno aluno = (from alunoX in contexto.Aluno
06
                   where alunoX.Nome == "João Felipe Portela"
07
                   select alunoX).First();
08
 
09
    // altera o nome do aluno
10
    aluno.Name = "João Felipe";
11
 
12
    // salva as alterações
13
    contexto.SaveChanges();
14
}
view sourceprint?
01
// remover
02
using (DBEntities contexto = new DBEntities())
03
{
04
    // seleciona um aluno especifico na lista de alunos
05
    Aluno aluno = (from alunoX in contexto.Aluno
06
                   where alunoX.Nome == "João Felipe Portela"
07
                   select alunoX).First();
08
 
09
    // remove da lista de alunos
10
    contexto.DeleteObject(aluno);
11
 
12
    // salva as alterações
13
    contexto.SaveChanges();
14
}
 
 */