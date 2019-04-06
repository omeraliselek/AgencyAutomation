using CastAutomation.MODEL.ORM.Enum;
using CastAutomation.MODEL.ORM.InterFace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CastAutomation.MODEL.ORM.Entity
{
    public class BaseEntity : IBaseEntity
    {
        public int ID { get; set; }
        private DateTime _AddDated = DateTime.Now;
        public DateTime AddDated { get {return _AddDated ; } set {_AddDated = value ; } }
        private DateTime _UpdatedDate = DateTime.Now;
        public DateTime UpdatedDate { get {return _UpdatedDate ; } set {_UpdatedDate=value; } }
        private DateTime _DeletedDate = DateTime.Now;
        public DateTime DeletedDate { get { return _DeletedDate; } set { _DeletedDate = value; } }

        //private Status Status = Status.Active;
        //public Status status { get { return status; } set { status = value; } }

    }
}
