//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace TeachSys.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TeacherClasses
    {
        public int ID { get; set; }
        public Nullable<int> TeacherID { get; set; }
        public Nullable<int> ClassID { get; set; }
        public int Status { get; set; }
    
        public virtual Classes Classes { get; set; }
        public virtual Teachers Teachers { get; set; }
    }
}
