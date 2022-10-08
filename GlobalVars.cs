
using System.Drawing;

static class Globals

{
    // Default variables

    // colours palette  to use from style guide extended colours
    public static Color darkRed = Color.FromArgb(163, 35, 35);
    public static Color lightRed = Color.FromArgb(207, 41, 47);
    public static Color coral = Color.FromArgb(216, 90, 79);
    public static Color nearBlack = Color.FromArgb(60, 60, 59);
    public static Color darkGray = Color.FromArgb(87, 87, 86);
    public static Color lightGray = Color.FromArgb(157, 157, 156);
    public static Color offWhite = Color.FromArgb(237, 237, 237);
    public static Color silver = Color.FromArgb(198, 198, 198);
    public static Color darkBlue = Color.FromArgb(87, 112, 219); // darkblue
    public static Color lightBlue = Color.FromArgb(87, 211, 219);  // light blue
    public static Color lightGreen = Color.FromArgb(145, 219, 87); // light green
    public static Color purple = Color.FromArgb(161, 87, 219);  // purple
    public static Color pink = Color.FromArgb(219, 95, 87);  // pink
    public static Color beige = Color.FromArgb(219, 194, 87); // beige
    public static Color orange = Color.Orange;
    public static Color gray = Color.Gray;

    // variable colour assignments
    public static Color defaultformsbgCol = offWhite;
    public static Color selectBtnfgCol = lightRed;
    public static Color settingsbgCol = darkGray;
    public static Color pmgridcellbgCol = offWhite;
    public static Color nopmgridcellbgCol = lightGray;
    public static Color notinusebgCol = gray;
    public static Color pmoverduebgCol = lightRed;
    public static Color pmoutstandingbgCol = orange;
    public static Color pmcompletedbgCol = lightGreen;
    public static Color gridcurrentweekbgCol = lightBlue;
    public static Color nolongerscheduledbgCol= lightGray;



    public static Color intvalCol1 = Color.FromArgb(87, 112, 219); // darkblue
    public static Color intvalCol2= Color.FromArgb(87, 211, 219);  // light blue
    public static Color intvalCol3 = Color.FromArgb(145, 219, 87); // light green
    public static Color intvalCol4 = Color.FromArgb(161, 87, 219);  // purple
    public static Color intvalCol5 = Color.FromArgb(219, 95, 87);  // pink
    public static Color intvalCol6 = Color.FromArgb(219, 194, 87); // beige

    //mpm intervalperiods
    public static string intVal1 = "1week";
    public static string intVal2 = "2weeks";
    public static string intVal3 = "1month";
    public static string intVal4 = "3months";
    public static string intVal5 = "6months";
    public static string intVal6 = "1year";

    // database connections
    
    public static string ConnBase = @"R:\eped\";
    public static string SqlPassword = "password=Effect2020";
    public static bool ChangesMade = false;
    public static string DefUser = "Guest";
    // user and application details
    public static int AccessLevel = 4;
    public static string CurrVersion = " 1.0.0.0";
    public static string AppName = "EPED";
    public static string BoldTick = "\u2714";
    // from db settings
    public static string EquipmentView = "Selection";
    public static string DuePeriodColor = "Amber";
    public static string OverDueColor = "Red";
    public static int AllowAssetsUpdate = 0;
    public static int AllowJobAllocation = 0;
    public static string MailFromAddress = "";
    public static string MailSmtpServer = "";
    public static string MailPortAddress = "";
    public static string MailLoginAddress = "";
    public static string MailPassword = "";
    public static string retErrorMessage = "";
    // reportsettins
    public static string documentContents = "";
    public static string stringToPrint = "";
    public static int reminderPeriodForMPM = 1;
    public static bool reportOnOverDue = false;
    }
