using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;
/*This is were the Model for the Booking System is made with data annotations added for validation purposes. It contains data logic based on the business and the type
 data needed for this web application*/
namespace UniqueSeafood.Models
{
    public class Booking
    {
        public int Id { get; set; }
        //[Required] is used for data that is needed for a data field
        [Required]
        //Title is always set to the string "Mr". Unless the user changes the title when adding a booking in the system.
        public string Title { get; set; } = "Mr";
        //Regular Expression is used to avoid any wrong inputs and provide the right data needed. An error message will pop up if the input is wrong
        [Required]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Error: Must use Alphabetical Characters")]
        public string FirstName { get; set; }
        [Required]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Error: Must use Alphabetical Characters")]
        public string LastName { get; set; }
        [Required]
        [Range(1, 60, ErrorMessage = "Error: Number of Guests must be between 0 to 60")]
        public int NumberOfGuests { get; set; }
        [Required]
        [RegularExpression(@"^\({0,1}((0|\+61)(2|4|3|7|8)){0,1}\){0,1}(\ |-){0,1}[0-9]{2}(\ |-){0,1}[0-9]{2}(\ |-){0,1}[0-9]{1}(\ |-){0,1}[0-9]{3}$", ErrorMessage = "Error: Must be an Australian Number")]
        public string ContactNumber { get; set; }
        [RegularExpression(@"^([a-zA-Z0-9._%-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,})$", ErrorMessage = "Error: Wrong E-Mail Format")]
        //Email Address and Special Request are Optional data fields that the user can type in
        public string? EmailAddress { get; set; }
        public string? SpecialRequest { get; set; }
        //Date and Time Fields are always set to the current time and date. Unless the user changes the date and time when adding a booking in the system.
        [Required]
        public DateOnly BookingDate { get; set; } = DateOnly.FromDateTime(DateTime.Now);
        [Required]
        public TimeOnly BookingTime { get; set; } = TimeOnly.FromDateTime(DateTime.Now);

    }
}   
