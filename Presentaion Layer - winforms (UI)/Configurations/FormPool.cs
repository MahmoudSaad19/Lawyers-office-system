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
       
        public static Reports Reports { get; } = new Reports();
    
        public static NewCase NewCase { get; } = new NewCase();
        public static NewClient NewClient { get; } = new NewClient();
        public static SanadSarf ReceiptForm { get; } = new SanadSarf();
        public static SanadKabdPaymentEdit paymentInfoEditForm { get; } = new SanadKabdPaymentEdit();
        public static SanadKabdEntryForm CatchReceiptForm { get; } = new SanadKabdEntryForm();
        public static MainPage MainPage { get; } = new MainPage();
        public static ShowClientCasesOrConsultation clientCases { get; } = new ShowClientCasesOrConsultation();

        public static ShowClientCasesOrConsultation ShowClientCases { get; } = new ShowClientCasesOrConsultation();
        public static EditClientCase EditClientCase { get; } = new EditClientCase();
        public static ShowClientInfo ShowClientInfo { get; } = new ShowClientInfo();

        public static EditClientConsultaion EditClientConsultaion { get; } = new EditClientConsultaion();

        public static SearchForClient SearchForClient{ get; } = new SearchForClient();
        public static SanadKabdPaymentEdit SanadKabdPaymentEdit{ get; } = new SanadKabdPaymentEdit();
    //static FormPool()
    //{
    //    if (HomePage is null)
    //        HomePage = new HomePage();
    //}
}
}
