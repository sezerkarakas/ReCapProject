using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public class Messages
    {

        public static string EntityNotUpdated = "The infromation you gave us is not correct please check it!";
        public static string MaintenanceTime = "System is under maintenance";

        public static string CarAdded = "Car added";
        public static string CarDeleted = "Car deleted";
        public static string CarUpdated = "Car updated";
        public static string CarNameInvalid = "Car name is invalid";
        public static string CarListed = "Cars are listed";

        public static string BrandAdded = "Brand added";
        public static string BrandDeleted = "Brand deleted";
        public static string BrandUpdated = "Brand updated";
        public static string BrandNameInvalid = "Brand name is invalid";
        public static string BrandListed = "Brand are listed";

        public static string ColorAdded = "Color added";
        public static string ColorDeleted = "Color deleted";
        public static string ColorUpdated = "Color updated";
        public static string ColorNameInvalid = "Color name is invalid";
        public static string ColorListed = "Color are listed";

        public static string UserAdded = "User added";
        public static string UserDeleted = "User deleted";
        public static string UserUpdated = "User updated";
        public static string UserNameInvalid = "User name is invalid";
        public static string UserListed = "User are listed";

        public static string CustomerAdded = "Customer added";
        public static string CustomerDeleted = "Customer deleted";
        public static string CustomerUpdated = "Customer updated";
        public static string CustomerNameInvalid = "Customer name is invalid";
        public static string CustomerListed = "Customer are listed";

        public static string RentalAdded = "You've rented a car";
        public static string RentalDeleted = "You've returned the car";
        public static string RentalUpdated = "Rent date updated";
        public static string RentalListed = "Rented cars listed";

        public static string CarImageLimitExceeded = "You've reached the photo limit you cannot go further!";

        public static string CarImageIsNotExists { get; internal set; }
    }
}
