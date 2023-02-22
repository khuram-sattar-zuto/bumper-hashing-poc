using Newtonsoft.Json;

namespace HashTest;

public class BumperObj
{
    public string amount { get; set; }
    public string api_key { get; set; }
    public string success_url { get; set; }
    public string failure_url { get; set; }
    public string currency { get; set; }
    public string order_reference { get; set; }
    public string signature { get; set; }
    public string first_name { get; set; }
    public string last_name { get; set; }
    public List<ProductDescription> product_description { get; set; }
    public string email { get; set; }
    public string product_id { get; set; }
    public string mobile { get; set; }
    public string vehicle_reg { get; set; }
    public string flat_number { get; set; }
    public string building_name { get; set; }
    public string building_number { get; set; }
    public string street { get; set; }
    public string town { get; set; }
    public string county { get; set; }
    public string postcode { get; set; }
    public string country { get; set; }
    public string is_preapproval_link { get; set; }
    public string preapproval_token { get; set; }
    public bool send_sms { get; set; }
    public bool send_email { get; set; }
}

public class ProductDescription
{
    public string item;
    public string quantity;
    public string price;
}