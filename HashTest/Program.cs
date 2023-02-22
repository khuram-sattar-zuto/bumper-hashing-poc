// See https://aka.ms/new-console-template for more information

using System.Security.Cryptography;
using System.Text;
using HashTest;


var bumper = new BumperObj
{
    amount = "300.00",
    api_key = "KdhM2oLZEeTvh08V3JBibrY1",
    success_url = "http://www.supplier.com/success/",
    failure_url = "http://www.supplier.com/failure/",
    currency = "GBP",
    order_reference = "26352",
    signature = "608a6d48e4271217b3aedf2f126ebb5990a6fdb763b599fffd1370df28ad643f",
    first_name = "John",
    last_name = "Smith",
    product_description = new List<ProductDescription>
    {
        new ProductDescription()
        {
            item = "Pirelli Cinturato P7 Tyre",
            quantity = "2",
            price = "150.00"
        },
        new ProductDescription
        {
            item =  "Pirelli Cinturato P8 Tyre",
            quantity = "1",
            price = "150.00"
        }
    },
    email = "john@smith.com",
    product_id = "4",
    mobile = "07788799896",
    vehicle_reg = "XYZ1234",
    flat_number = "23",
    building_name = "ABC Building",
    building_number = "39",
    street = "DEF way",
    town = "Southampton",
    county = "Hampshire",
    postcode = "SO14 3AB",
    country = "UK",
    is_preapproval_link = "true",
    preapproval_token = "32248992",
    send_sms = false,
    send_email = false
};

var key = "5cn7XUP4sgCla2BmlI7zMpRn";
using var hmac = new HMACSHA256(Encoding.ASCII.GetBytes(key));
var stringMessage = bumper.GenerateQueryStringForSignature();
var buffer = Encoding.ASCII.GetBytes(stringMessage);
var signature = Convert.ToHexString(hmac.ComputeHash(buffer));
Console.WriteLine(signature);
Console.WriteLine(signature.ToLower());
