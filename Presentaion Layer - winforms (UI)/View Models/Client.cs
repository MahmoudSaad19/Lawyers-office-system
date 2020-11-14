using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentaion_Layer___winforms__UI_.View_Models
{
    public class Client
    {

        [DisplayName("الاسم")]
        public string Name { get; set; }
        [DisplayName("رقم المدنية")]
        public string SSN { get; set; }
        [DisplayName("العنوان")]
        public string Address { get; set; }
        [DisplayName("التليفون")]
        public string Telphone { get; set; }
        [DisplayName("الإيميل")]
        public string Email { get; set; }
        [DisplayName("المهنة")]
        public string Job { get; set; }

        [DisplayName("عدد القضايا")]
        public int NumberOfCases { get; set; }
        [DisplayName("ملاحظات")]
        public string Notes { get; set; }

        public static List<Client> Data()
        {
            List<Client> clients = new List<Client>()
            {
                new Client(){ Address= "التجمع اللأول", Email="ali.mohamed@gmail.com", Job=" مهندس", Name=" على محمد على ", Notes="حديث التخرج", NumberOfCases = 3, SSN = "١٤٦٧٩٠١٤٦٧٩٠٩٠", Telphone = "٠١٤٦٧٩٠١٤٠"},
                new Client(){ Address= "التجمع اللأول", Email="ali.mohamed@gmail.com", Job=" مهندس", Name="  محمد على ", Notes="حديث التخرج", NumberOfCases = 3, SSN = "١٤٦٧٩٠١٤٦٧٩٠٩٠", Telphone = "٠١٤٦٧٩٠١٤٠"},
                new Client(){ Address= "التجمع اللأول", Email="ali.mohamed@gmail.com", Job=" مهندس", Name=" على محمود على ", Notes="حديث التخرج", NumberOfCases = 3, SSN = "١٤٦٧٩٠١٤٦٧٩٠٩٠", Telphone = "٠١٤٦٧٩٠١٤٠"},
                new Client(){ Address= "التجمع اللأول", Email="ali.mohamed@gmail.com", Job=" مهندس", Name="  محمود على ", Notes="حديث التخرج", NumberOfCases = 3, SSN = "١٤٦٧٩٠١٤٦٧٩٠٩٠", Telphone = "٠١٤٦٧٩٠١٤٠"},
                new Client(){ Address= "التجمع اللأول", Email="ali.mohamed@gmail.com", Job=" مهندس", Name=" حسين صابر ", Notes="حديث التخرج", NumberOfCases = 3, SSN = "١٤٦٧٩٠١٤٦٧٩٠٩٠", Telphone = "٠١٤٦٧٩٠١٤٠"},
                new Client(){ Address= "التجمع اللأول", Email="ali.mohamed@gmail.com", Job=" مهندس", Name=" إسلام جمال ", Notes="حديث التخرج", NumberOfCases = 3, SSN = "١٤٦٧٩٠١٤٦٧٩٠٩٠", Telphone = "٠١٤٦٧٩٠١٤٠"},
                new Client(){ Address= "التجمع اللأول", Email="ali.mohamed@gmail.com", Job=" مهندس", Name=" عمرو حسين ", Notes="حديث التخرج", NumberOfCases = 3, SSN = "١٤٦٧٩٠١٤٦٧٩٠٩٠", Telphone = "٠١٤٦٧٩٠١٤٠"},
                new Client(){ Address= "التجمع اللأول", Email="ali.mohamed@gmail.com", Job=" مهندس", Name=" شريف فريد ", Notes="حديث التخرج", NumberOfCases = 3, SSN = "١٤٦٧٩٠١٤٦٧٩٠٩٠", Telphone = "٠١٤٦٧٩٠١٤٠"},
                new Client(){ Address= "الدقى", Email="a@b.com", Job="عامل", Name="عماد كمال", Notes="سنة ", NumberOfCases = 3, SSN = "١٤٦٧٩٠", Telphone = "١٤٦٧٩٠"}
            };
            return clients;
        }
    }
}
