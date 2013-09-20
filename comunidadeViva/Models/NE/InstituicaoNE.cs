using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using comunidadeViva.Models.Base;
using comunidadeViva.Models.Dao;

namespace comunidadeViva.Models.NE
{


    public class NE_Instituicao
    {

        Dao_Instituicao dao = new Dao_Instituicao();


        public Instituicao findById(int id)
        {
            return dao.getContext().Instituicaos.Where(i => i.IdInstituicao == id).FirstOrDefault();
        }

        public bool save(Instituicao instituicao)
        {
            try
            {
                dao.save(instituicao);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

    }
}