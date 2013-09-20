using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using comunidadeViva.Models;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace comunidadeViva.controller
{
    public class Ne_Instituicaos
    {
        public void GravarInstituicao(Instituicao objInstituicao)
        {
            using (DbComunicadaVivaContext contexto = new DbComunicadaVivaContext())
            {

                contexto.Instituicaos.Add(objInstituicao);
                contexto.SaveChanges();

            }
        }
    }
}