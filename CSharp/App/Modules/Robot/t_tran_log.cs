//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Modules.Robot
{
    using System;
    using System.Collections.Generic;
    
    public partial class t_tran_log
    {
        public string tran_listid { get; set; }
        public Nullable<decimal> buyer_guid { get; set; }
        public string buyer_account { get; set; }
        public Nullable<decimal> seller_guid { get; set; }
        public string seller_account { get; set; }
        public Nullable<short> assets_type { get; set; }
        public Nullable<int> pay_amount { get; set; }
        public string bill_listid { get; set; }
        public string ip { get; set; }
        public string memo { get; set; }
        public Nullable<System.DateTime> create_time { get; set; }
        public Nullable<System.DateTime> modify_time { get; set; }
    }
}
