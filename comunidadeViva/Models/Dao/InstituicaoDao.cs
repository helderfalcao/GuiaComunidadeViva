using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace comunidadeViva.Models.Dao
{
    using Base;
    using comunidadeViva.Models;
    using Models;

    public class Dao_Instituicao : Base.BaseDao<Instituicao>
    {
        public override bool canSave(Instituicao entity)
        {
            return true;
        }

        public override Instituicao reload(int code)
        {
            return getContext().Instituicaos.Where(inst => inst.IdInstituicao == code).FirstOrDefault();
        }



    }
}