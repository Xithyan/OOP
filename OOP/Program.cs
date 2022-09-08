using OOP;

//Address address1 = new();

//Contact contact1 = new();

//contact1.Addresses.Add(address1);
bool run = true;
string name;
string answer = null;
ProfileType type = ProfileType.None;
Options option = Options.None;
ConsoleColor dftForeColor = Console.ForegroundColor;
ConsoleColor dftBackColor = Console.BackgroundColor;
ConsoleColor newForeColor = ConsoleColor.White;
ConsoleColor newBackColor = ConsoleColor.Black;


do
{

    Console.WriteLine("Choose an Option");
    Console.WriteLine("");
    Console.WriteLine("(A)dd Profile");
    Console.WriteLine("(E)dit Profile");
    Console.WriteLine("(D)elete Profile");
    Console.WriteLine("(L)ist all Profiles");
    Console.WriteLine("(Q)uit");
    string optionPick = Console.ReadLine();

    if (optionPick.ToLower() == "a")
    {
        option = Options.Add;
    }
    else if (optionPick.ToLower() == "e")
    {
        option = Options.Edit;
    }
    else if (optionPick.ToLower() == "d")
    {
        option = Options.Delete;
    }
    else if (optionPick.ToLower() == "l")
    {
        option = Options.Show_All;
    }
    else if (optionPick.ToLower() == "q")
    {
        run = false;
    }

    switch (option)
    {
        case Options.Add:
            string inputType;
            string inputLink;
            string inputPassword;
            Console.WriteLine("Create Profile: ");
            Console.WriteLine("(P)rivate/(B)usiness");
            string profileType = Console.ReadLine();
            if (profileType.ToLower() == "b")
            {
                type = ProfileType.Business;
            }
            else if (profileType.ToLower() == "p")
            {
                type = ProfileType.Private;
            }
            else
            {
                Console.WriteLine("Wrong Input");
            }
            Contact contact = new();
            Address newContactAddress = new();
            WalletAddress newContactWallet = new();


            switch (type)
            {
                case ProfileType.Business:
                    Console.WriteLine("First Name");
                    string inputFirstName = Console.ReadLine();
                    Functions.InputFirstName(inputFirstName, contact);
                    Console.WriteLine("Middle Name (Optional)");
                    string inputMiddleName = Console.ReadLine();
                    Functions.InputMiddleName(inputMiddleName, contact);
                    Console.WriteLine("Last Name");
                    string inputLastName = Console.ReadLine();
                    Functions.InputLastName(inputLastName, contact);
                    Console.WriteLine("Company/Business");
                    string inputBusiness = Console.ReadLine();
                    Functions.InputBusiness(inputBusiness, contact);
                    Console.WriteLine("Input your Address");
                    Console.WriteLine("Street: ");
                    string inputStreet = Console.ReadLine();
                    Functions.InputStreet(inputStreet, newContactAddress);
                    Console.WriteLine("Housenumber: ");
                    string inputHousenumber = Console.ReadLine();
                    Functions.InputHousenumber(inputHousenumber, newContactAddress);
                    Console.WriteLine("ZipCode: ");
                    string inputZipCode = Console.ReadLine();
                    Functions.InputZipCode(inputZipCode, newContactAddress);
                    Console.WriteLine("City: ");
                    string inputCity = Console.ReadLine();
                    Functions.InputCity(inputCity, newContactAddress);
                    Console.WriteLine("Country: ");
                    string inputCountry = Console.ReadLine();
                    Functions.InputCountry(inputCountry, newContactAddress);
                    Console.WriteLine("Province/State: ");
                    string inputProvince = Console.ReadLine();
                    Functions.InputProvince(inputProvince, newContactAddress);
                    contact.Addresses.Add(newContactAddress);
                    Functions.BusinessContacts.Add(contact);
                    break;

                case ProfileType.Private:

                    Console.WriteLine("First Name");
                    inputFirstName = Console.ReadLine();
                    Console.WriteLine("Middle Name (Optional)");
                    inputMiddleName = Console.ReadLine();
                    Console.WriteLine("Last Name");
                    inputLastName = Console.ReadLine();
                    Console.WriteLine("Input your Address");
                    Console.WriteLine("Street: ");
                    newContactAddress.Street = Console.ReadLine();
                    Console.WriteLine("Housenumber: ");
                    inputHousenumber = Console.ReadLine();
                    Functions.InputHousenumber(inputHousenumber, newContactAddress);
                    Console.WriteLine("ZipCode: ");
                    inputZipCode = Console.ReadLine();
                    Functions.InputZipCode(inputZipCode, newContactAddress);
                    Console.WriteLine("City: ");
                    inputCity = Console.ReadLine();
                    Functions.InputCity(inputCity, newContactAddress);
                    Console.WriteLine("Country: ");
                    inputCountry = Console.ReadLine();
                    Functions.InputCountry(inputCountry, newContactAddress);
                    Console.WriteLine("Province/State: ");
                    inputProvince = Console.ReadLine();
                    Functions.InputProvince(inputProvince, newContactAddress);
                    contact.Addresses.Add(newContactAddress);
                    Functions.PrivateContacts.Add(contact);
                    break;
            }
            WalletAddress? newWallet = new();
            Console.WriteLine("Add Crypto Wallet?");
            Console.WriteLine("Y/N?");
            string walletAdd = Console.ReadLine();
            if (walletAdd.ToLower() == "y")
            {
                WalletType wallet = WalletType.None;
                Console.WriteLine("Select Crypto Currency");
                Console.WriteLine("(0)Bitcoin");
                Console.WriteLine("(1)Ethereum");
                Console.WriteLine("(2)Ripple");
                Console.WriteLine("(3)Bitcoin_Cash");
                Console.WriteLine("(4)EOS");
                Console.WriteLine("(5)Cardano");
                Console.WriteLine("(6)Litecoin");
                Console.WriteLine("(7)Stellar");
                Console.WriteLine("(8)IOTA");
                Console.WriteLine("(9)NEO");
                Console.WriteLine("(10)Monero");

                var walletSelect = Console.ReadLine();

                switch (walletSelect)
                {
                    case "0":
                        wallet = WalletType.Bitcoin;
                        break;
                    case "1":
                        wallet = WalletType.Ethereum;
                        break;
                    case "2":
                        wallet = WalletType.Ripple;
                        break;
                    case "3":
                        wallet = WalletType.Bitcoin_Cash;
                        break;
                    case "4":
                        wallet = WalletType.EOS;
                        break;
                    case "5":
                        wallet = WalletType.Cardano;
                        break;
                    case "6":
                        wallet = WalletType.Litecoin;
                        break;
                    case "7":
                        wallet = WalletType.Stellar;
                        break;
                    case "8":
                        wallet = WalletType.IOTA;
                        break;
                    case "9":
                        wallet = WalletType.NEO;
                        break;
                    case "10":
                        wallet = WalletType.Monero;
                        break;
                }
                switch (wallet)
                {
                    case WalletType.Bitcoin:
                        Console.WriteLine("Wallet Link");
                        string inputWalletAddress = Console.ReadLine();
                        Functions.InputWallet(inputWalletAddress, newWallet);
                        Console.WriteLine("Password");
                        string inputWalletPassword = Console.ReadLine();
                        Functions.InputWalletPassword(inputWalletPassword, newWallet);
                        break;
                    case WalletType.Ethereum:
                        Console.WriteLine("Wallet Link");
                        inputWalletAddress = Console.ReadLine();
                        Functions.InputWallet(inputWalletAddress, newWallet);
                        Console.WriteLine("Password");
                        inputWalletPassword = Console.ReadLine();
                        Functions.InputWalletPassword(inputWalletPassword, newWallet);
                        break;
                    case WalletType.Ripple:
                        Console.WriteLine("Wallet Link");
                        inputWalletAddress = Console.ReadLine();
                        Functions.InputWallet(inputWalletAddress, newWallet);
                        Console.WriteLine("Password");
                        inputWalletPassword = Console.ReadLine();
                        Functions.InputWalletPassword(inputWalletPassword, newWallet);
                        break;
                    case WalletType.Bitcoin_Cash:
                        Console.WriteLine("Wallet Link");
                        inputWalletAddress = Console.ReadLine();
                        Functions.InputWallet(inputWalletAddress, newWallet);
                        Console.WriteLine("Password");
                        inputWalletPassword = Console.ReadLine();
                        Functions.InputWalletPassword(inputWalletPassword, newWallet);
                        break;
                    case WalletType.EOS:
                        Console.WriteLine("Wallet Link");
                        inputWalletAddress = Console.ReadLine();
                        Functions.InputWallet(inputWalletAddress, newWallet);
                        Console.WriteLine("Password");
                        inputWalletPassword = Console.ReadLine();
                        Functions.InputWalletPassword(inputWalletPassword, newWallet);
                        break;
                    case WalletType.Cardano:
                        Console.WriteLine("Wallet Link");
                        inputWalletAddress = Console.ReadLine();
                        Functions.InputWallet(inputWalletAddress, newWallet);
                        Console.WriteLine("Password");
                        inputWalletPassword = Console.ReadLine();
                        Functions.InputWalletPassword(inputWalletPassword, newWallet);
                        break;
                    case WalletType.Litecoin:
                        Console.WriteLine("Wallet Link");
                        inputWalletAddress = Console.ReadLine();
                        Functions.InputWallet(inputWalletAddress, newWallet);
                        Console.WriteLine("Password");
                        inputWalletPassword = Console.ReadLine();
                        Functions.InputWalletPassword(inputWalletPassword, newWallet);
                        break;
                    case WalletType.Stellar:
                        Console.WriteLine("Wallet Link");
                        inputWalletAddress = Console.ReadLine();
                        Functions.InputWallet(inputWalletAddress, newWallet);
                        Console.WriteLine("Password");
                        inputWalletPassword = Console.ReadLine();
                        Functions.InputWalletPassword(inputWalletPassword, newWallet);
                        break;
                    case WalletType.IOTA:
                        Console.WriteLine("Wallet Link");
                        inputWalletAddress = Console.ReadLine();
                        Functions.InputWallet(inputWalletAddress, newWallet);
                        Console.WriteLine("Password");
                        inputWalletPassword = Console.ReadLine();
                        Functions.InputWalletPassword(inputWalletPassword, newWallet);
                        break;
                    case WalletType.NEO:
                        Console.WriteLine("Wallet Link");
                        inputWalletAddress = Console.ReadLine();
                        Functions.InputWallet(inputWalletAddress, newWallet);
                        Console.WriteLine("Password");
                        inputWalletPassword = Console.ReadLine();
                        Functions.InputWalletPassword(inputWalletPassword, newWallet);
                        break;
                    case WalletType.Monero:
                        Console.WriteLine("Wallet Link");
                        inputWalletAddress = Console.ReadLine();
                        Functions.InputWallet(inputWalletAddress, newWallet);
                        Console.WriteLine("Password");
                        inputWalletPassword = Console.ReadLine();
                        Functions.InputWalletPassword(inputWalletPassword, newWallet);
                        break;
                }

                contact.WalletAddresses.Add(newWallet);
            }
            foreach (var address in contact.Addresses)
            {
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine(contact.FirstName);
                Console.WriteLine(contact.MiddleName);
                Console.WriteLine(contact.LastName);
                Console.WriteLine(address.Street);
                Console.WriteLine(address.Housenumber);
                Console.WriteLine(address.ZipCode);
                Console.WriteLine(address.City);
                Console.WriteLine(address.Country);
                Console.WriteLine(address.Province);
                //Console.WriteLine(address.Type);
                //Console.WriteLine(address.Link);
                //Console.WriteLine(address.Password);
            }
            foreach (var crypto in contact.WalletAddresses)
            {
                Console.WriteLine(crypto.Type);
                Console.WriteLine(crypto.Link);
                Console.WriteLine(crypto.Password);
            }
            break;

        case Options.Edit:
            Console.WriteLine("Enter Name to Edit");
            name = Console.ReadLine();
            if (name == null)
            {
                Console.WriteLine("Profile not Found");
            }
            else
            {
                Console.WriteLine("(P)rivate/(B)usiness");
                profileType = Console.ReadLine();
                if (profileType.ToLower() == "b")
                {
                    type = ProfileType.Business;
                }
                else if (profileType.ToLower() == "p")
                {
                    type = ProfileType.Private;
                }
                else
                {
                    Console.WriteLine("Wrong Input");
                }
            }
            break;
        
        case Options.Delete:

            break;

        //case Options.Show_All:
        //    try
        //    {
                //using(StreamReader users = new StreamReader(contact.Addresses, true))
                //{
                //    while()
                //    {

                //    }
                //}
            //}
            //if (contact.Addresses == null)
            //{
            //    Console.WriteLine("Contact not Found");
            //}
            //else
            //{
            //    //Console.WriteLine("Contacts Availabe");
            //    //contact.Addresses((a) => Console.WriteLine(a.name, a.address));
            //}
            //break;

        case Options.Quit:
            run = false;
            break;

    }
    do
    {
        Console.WriteLine("Continue? Y/N");
        answer = Console.ReadLine().ToLower();
        if (answer == "n")
            run = false;
        else if (answer != "y" && answer != "n")
            Console.WriteLine("Wrong Input!");
    }
    while (answer != "n" && answer != "y");
}
while (run);