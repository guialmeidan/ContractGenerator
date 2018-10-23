using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principal.Domain.Entities
{
    public class Opportunity
    {
        public class MainOpportunity
        {
            public int id { get; set; }
            public string title { get; set; }
            public string lat { get; set; }
            public string lng { get; set; }
            public string url { get; set; }
            public string location { get; set; }
            public string status { get; set; }
            public string description { get; set; }
            public bool is_gep { get; set; }
            public string current_status { get; set; }
            public object duration_min { get; set; }
            public object duration_max { get; set; }
            public int duration { get; set; }
            public int project_duration { get; set; }
            public string google_place_id { get; set; }
            public OpportunityCost opportunity_cost { get; set; }
            public object video_url { get; set; }
            public object transparent_fee_details { get; set; }
            public bool is_ge { get; set; }
            public Programmes programmes { get; set; }
            public SubProduct sub_product { get; set; }
            public bool is_favourited { get; set; }
            public int favourites { get; set; }
            public object remark { get; set; }
            public bool applied_to { get; set; }
            public bool applied_to_with { get; set; }
            public DateTime earliest_start_date { get; set; }
            public DateTime latest_end_date { get; set; }
            public DateTime applications_close_date { get; set; }
            public int applications_count { get; set; }
            public OpenedBy opened_by { get; set; }
            public List<object> latest_reviews { get; set; }
            public int office_footfall_for_exchange { get; set; }
            public HostLc host_lc { get; set; }
            public HomeLc2 home_lc { get; set; }
            public List<Manager> managers { get; set; }
            public Branch branch { get; set; }
            public object team { get; set; }
            public object project { get; set; }
            public object tn_manager_info { get; set; }
            public int openings { get; set; }
            public int available_openings { get; set; }
            public List<Nationality> nationalities { get; set; }
            public List<Skill> skills { get; set; }
            public List<Background> backgrounds { get; set; }
            public List<Language> languages { get; set; }
            public List<object> measure_of_impacts { get; set; }
            public List<object> issues { get; set; }
            public List<StudyLevel> study_levels { get; set; }
            public List<object> preferred_locations_info { get; set; }
            public LogisticsInfo logistics_info { get; set; }
            public TmDetails tm_details { get; set; }
            public LegalInfo legal_info { get; set; }
            public RoleInfo role_info { get; set; }
            public object department { get; set; }
            public SpecificsInfo specifics_info { get; set; }
            public object sdg_info { get; set; }
            public int nps_score { get; set; }
            public Reviews reviews { get; set; }
            public List<object> comments { get; set; }
            public object scorecard { get; set; }
            public ProfilePhotoUrls2 profile_photo_urls { get; set; }
            public string cover_photo_urls { get; set; }
            public Permissions permissions { get; set; }
            public DateTime created_at { get; set; }
            public DateTime updated_at { get; set; }
        }
        public class OpportunityCost
        {
            public int programme_fee { get; set; }
            public double project_fee { get; set; }
            public double total { get; set; }
            public string currency { get; set; }
        }

        public class Programmes
        {
            public int id { get; set; }
            public string short_name { get; set; }
        }

        public class Programmes2
        {
            public int id { get; set; }
            public string short_name { get; set; }
        }

        public class SubProduct
        {
            public int id { get; set; }
            public string name { get; set; }
            public Programmes2 programmes { get; set; }
        }

        public class HomeLc
        {
            public int id { get; set; }
            public string name { get; set; }
            public string country { get; set; }
        }

        public class ContactInfo
        {
            public object website { get; set; }
            public string email { get; set; }
            public string phone { get; set; }
            public string facebook { get; set; }
            public object twitter { get; set; }
            public string instagram { get; set; }
            public object linkedin { get; set; }
            public string country_code { get; set; }
        }

        public class OpenedBy
        {
            public int id { get; set; }
            public string full_name { get; set; }
            public string email { get; set; }
            public HomeLc home_lc { get; set; }
            public string profile_photo_url { get; set; }
            public string cover_photo_url { get; set; }
            public ContactInfo contact_info { get; set; }
        }

        public class HostLc
        {
            public int id { get; set; }
            public string name { get; set; }
            public string full_name { get; set; }
            public string email { get; set; }
            public string tag { get; set; }
            public int parent_id { get; set; }
            public object signup_link { get; set; }
            public string country { get; set; }
            public string url { get; set; }
            public string profile_photo_url { get; set; }
            public string cover_photo_url { get; set; }
        }

        public class HomeLc2
        {
            public int id { get; set; }
            public string name { get; set; }
            public string full_name { get; set; }
            public string email { get; set; }
            public string tag { get; set; }
            public int parent_id { get; set; }
            public object signup_link { get; set; }
            public string country { get; set; }
            public string url { get; set; }
            public string profile_photo_url { get; set; }
            public string cover_photo_url { get; set; }
        }

        public class HomeLc3
        {
            public int id { get; set; }
            public string name { get; set; }
            public string country { get; set; }
        }

        public class ContactInfo2
        {
            public object website { get; set; }
            public object email { get; set; }
            public string phone { get; set; }
            public object facebook { get; set; }
            public object twitter { get; set; }
            public object instagram { get; set; }
            public object linkedin { get; set; }
            public string country_code { get; set; }
        }

        public class Manager
        {
            public int id { get; set; }
            public string full_name { get; set; }
            public string email { get; set; }
            public HomeLc3 home_lc { get; set; }
            public string profile_photo_url { get; set; }
            public string cover_photo_url { get; set; }
            public ContactInfo2 contact_info { get; set; }
        }

        public class Meta
        {
            public string opportunity_count { get; set; }
        }

        public class ContactInfo3
        {
            public string website { get; set; }
            public string email { get; set; }
            public string phone { get; set; }
            public object facebook { get; set; }
            public object twitter { get; set; }
            public object instagram { get; set; }
            public string linkedin { get; set; }
            public string country_code { get; set; }
        }

        public class ProfilePhotoUrls
        {
            public string original { get; set; }
            public string medium { get; set; }
            public string thumb { get; set; }
        }

        public class Organisation
        {
            public int id { get; set; }
            public string name { get; set; }
            public Meta meta { get; set; }
            public string url { get; set; }
            public object website { get; set; }
            public string summary { get; set; }
            public bool is_gep { get; set; }
            public object registration_no { get; set; }
            public object experience_count { get; set; }
            public object year_of_creation { get; set; }
            public ContactInfo3 contact_info { get; set; }
            public ProfilePhotoUrls profile_photo_urls { get; set; }
            public string cover_photo_urls { get; set; }
        }

        public class Coordinates
        {
            public string latitude { get; set; }
            public string longitude { get; set; }
        }

        public class AddressInfo
        {
            public string address_1 { get; set; }
            public object address_2 { get; set; }
            public object postcode { get; set; }
            public string city { get; set; }
            public string country { get; set; }
            public Coordinates coordinates { get; set; }
            public object city_name { get; set; }
            public object country_name { get; set; }
        }

        public class ContactInfo4
        {
            public object website { get; set; }
            public string email { get; set; }
            public string phone { get; set; }
            public object facebook { get; set; }
            public object twitter { get; set; }
            public object instagram { get; set; }
            public object linkedin { get; set; }
            public object country_code { get; set; }
        }

        public class Branch
        {
            public int id { get; set; }
            public string name { get; set; }
            public object scope { get; set; }
            public string status { get; set; }
            public Organisation organisation { get; set; }
            public AddressInfo address_info { get; set; }
            public object billing_address { get; set; }
            public string url { get; set; }
            public ContactInfo4 contact_info { get; set; }
        }

        public class Nationality
        {
            public string option { get; set; }
            public object level { get; set; }
            public int id { get; set; }
            public string name { get; set; }
            public object matching_with_opportunity { get; set; }
        }

        public class Skill
        {
            public string option { get; set; }
            public int level { get; set; }
            public int id { get; set; }
            public string name { get; set; }
            public object matching_with_opportunity { get; set; }
        }

        public class Background
        {
            public string option { get; set; }
            public object level { get; set; }
            public int id { get; set; }
            public string name { get; set; }
            public object matching_with_opportunity { get; set; }
        }

        public class Language
        {
            public string option { get; set; }
            public int level { get; set; }
            public int id { get; set; }
            public string name { get; set; }
            public object matching_with_opportunity { get; set; }
        }

        public class StudyLevel
        {
            public int id { get; set; }
            public string name { get; set; }
            public object matching_with_opportunity { get; set; }
        }

        public class LogisticsInfo
        {
            public string food_covered { get; set; }
            public string food_weekends { get; set; }
            public string accommodation_covered { get; set; }
            public string accommodation_provided { get; set; }
            public string transportation_covered { get; set; }
            public string transportation_weekends { get; set; }
        }

        public class TmDetails
        {
        }

        public class LegalInfo
        {
            public string visa_link { get; set; }
            public string visa_type { get; set; }
            public string visa_duration { get; set; }
            public string health_insurance_info { get; set; }
        }

        public class RoleInfo
        {
            public string city { get; set; }
            public object required_preparation { get; set; }
            public object learning_points { get; set; }
            public List<string> learning_points_list { get; set; }
            public object additional_instructions { get; set; }
            public string selection_process { get; set; }
        }

        public class SalaryCurrency
        {
            public int id { get; set; }
            public string name { get; set; }
            public string alphabetic_code { get; set; }
            public int numeric_code { get; set; }
            public int minor_unit { get; set; }
            public DateTime created_at { get; set; }
            public DateTime updated_at { get; set; }
            public double usd_denominator { get; set; }
            public object symbol { get; set; }
        }

        public class ExpectedWorkSchedule
        {
            public string from { get; set; }
            public string to { get; set; }
        }

        public class SpecificsInfo
        {
            public string salary { get; set; }
            public SalaryCurrency salary_currency { get; set; }
            public string ask_gip_question { get; set; }
            public string salary_periodicity { get; set; }
            public string ef_test_required { get; set; }
            public bool computer { get; set; }
            public bool saturday_work { get; set; }
            public ExpectedWorkSchedule expected_work_schedule { get; set; }
            public object saturday_work_schedule { get; set; }
        }

        public class Reviews
        {
            public double score { get; set; }
            public int count { get; set; }
        }

        public class ProfilePhotoUrls2
        {
            public string original { get; set; }
            public string medium { get; set; }
            public string thumb { get; set; }
        }

        public class Permissions
        {
            public bool can_update { get; set; }
            public bool can_edit_managers { get; set; }
            public bool can_open { get; set; }
            public bool can_be_applied_to { get; set; }
            public bool view_applications { get; set; }
            public bool can_mark_gep { get; set; }
        }

        
    }
}
