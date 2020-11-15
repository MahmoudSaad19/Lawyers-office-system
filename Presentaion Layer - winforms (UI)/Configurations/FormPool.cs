using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentaion_Layer___winforms__UI_
{
    public static class FormPool
    {
        public static HomePage HomePage { get; } = new HomePage();
        public static Case Case { get; } = new Case();
        public static Consultancy Consultancy { get; } = new Consultancy();
        public static Payment Payment { get; } = new Payment();
        public static Reports Reports { get; } = new Reports();
        public static ReceiveFees Fees { get; } = new ReceiveFees();
        public static NewCase NewCase { get; } = new NewCase();
        public static NewClient NewClient { get; } = new NewClient();
        public static ReceiptForm ReceiptForm { get; } = new ReceiptForm();
        public static PaymentInfoEditForm PaymentInfo { get; } = new PaymentInfoEditForm();


        //static FormPool()
        //{
        //    if (HomePage is null)
        //        HomePage = new HomePage();
        //}
    }
}
