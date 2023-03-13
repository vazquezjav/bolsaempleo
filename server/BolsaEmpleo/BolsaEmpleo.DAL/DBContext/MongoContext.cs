
//using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BolsaEmpleo.DAL.DBContext
{
    public class MongoContext
    {
        /*public readonly IMongoCollection<ProfileUser> users;
        public readonly IMongoCollection<AuthUserNotification> notifications;
        public readonly IMongoCollection<CustomerCategoryModel> cusCategories;
        public readonly IMongoCollection<SalesFamilyModel> salesFamily;
        public readonly IMongoCollection<UniqueCustomerResumeModel> uniquecustomer;
        public readonly IMongoCollection<TotalResumeModel> totalresume;
        public readonly IMongoCollection<ClusterSectionModel> clusterSection;
        public readonly IMongoCollection<ClusterPropertiesModel> clusterProperty;
        public readonly IMongoCollection<ClusterCompareData> clusterCompareData;
        public readonly IMongoCollection<DashboardUCustomerModel> dashboarducustomer;
        public readonly IMongoCollection<DashboardData> dashdata;
        public readonly IMongoCollection<Eeff_Saldos_Ebi_VModel> eeffSaldoEbiV;
        public readonly IMongoCollection<WMargenValue> widgetConsolidate;

        public readonly IMongoCollection<ConnectionsModel> conecctions;
        public readonly IMongoCollection<REPasswordModel> repassword;

        public readonly IMongoCollection<TemplatesMailModel> mailtemplate;
        public readonly IMongoCollection<CampainModel> col_campains;
        public readonly IMongoCollection<CampainRecipientsModel> col_campains_recients;
        public readonly IMongoCollection<CampainTaskManager> col_campains_task;
        public readonly IMongoCollection<CampainEmailResponse> col_campains_response_mail;
        public readonly IMongoCollection<UserToDoListModel> col_user_todo_list_model;
        public readonly IMongoCollection<ZBBMonthMongo> eeff_zbb_month;
        public readonly IMongoCollection<ZBBMonthDetailMongo> eeff_zbb_detail;
        public readonly IMongoCollection<EmpleadoModelView> tthh_employee_vw;
        public readonly IMongoCollection<DataUserDemographicModel> DataCustomerDemographic;

        public MongoContext(IMongoSetting setting)
        {
            var client = new MongoClient(setting.MongoDBConnection);
            var database = client.GetDatabase(setting.Database);

            this.users = database.GetCollection<ProfileUser>("auth_user_profile");
            this.notifications = database.GetCollection<AuthUserNotification>("auth_user_notifications");
            this.cusCategories = database.GetCollection<CustomerCategoryModel>("dash_category_customer_data");
            this.salesFamily = database.GetCollection<SalesFamilyModel>("dash_sales_family");
            this.uniquecustomer = database.GetCollection<UniqueCustomerResumeModel>("cust_unique_customer_resume");
            this.totalresume = database.GetCollection<TotalResumeModel>("dash_total_resume");
            this.clusterSection = database.GetCollection<ClusterSectionModel>("comp_section_data");
            this.clusterProperty = database.GetCollection<ClusterPropertiesModel>("comp_property_data");
            this.clusterCompareData = database.GetCollection<ClusterCompareData>("comp_compare_data");
            this.dashboarducustomer = database.GetCollection<DashboardUCustomerModel>("dash_dashboard_ucustomer");
            this.dashdata = database.GetCollection<DashboardData>("dash_dashboard_data");
            this.eeffSaldoEbiV = database.GetCollection<Eeff_Saldos_Ebi_VModel>("eeff_saldos_ebi_v");
            this.widgetConsolidate = database.GetCollection<WMargenValue>("widget_finance_consolidate");
            this.mailtemplate = database.GetCollection<TemplatesMailModel>("mail_templates");
            this.col_campains = database.GetCollection<CampainModel>("mail_campains");
            this.col_campains_recients = database.GetCollection<CampainRecipientsModel>("mail_campains_recients");
            this.col_campains_task = database.GetCollection<CampainTaskManager>("mail_campains_task");
            this.col_campains_response_mail = database.GetCollection<CampainEmailResponse>("mail_campains_response_mail");
            this.col_user_todo_list_model = database.GetCollection<UserToDoListModel>("comp_user_todo_list_model");
            this.eeff_zbb_month = database.GetCollection<ZBBMonthMongo>("eeff_zbb_month");
            this.eeff_zbb_detail = database.GetCollection<ZBBMonthDetailMongo>("eeff_zbb_month_detail");
            this.conecctions = database.GetCollection<ConnectionsModel>("connection");
            this.tthh_employee_vw = database.GetCollection<EmpleadoModelView>("tthh_employee_vw");
            this.repassword = database.GetCollection<REPasswordModel>("rec_email_password");
            this.DataCustomerDemographic = database.GetCollection<DataUserDemographicModel>("data_user_demographic");

        }*/

    }

}
