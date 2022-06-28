namespace AutoService.Client.Enums;

public class Helper
{
    public static string RequestParser(int value)
    {
        switch ((ServiceRequestStatusEnum) value)
        {
            case ServiceRequestStatusEnum.Waiting:
                return "Waiting";
                break;
            case ServiceRequestStatusEnum.Done:
                return "Checked";
                break;
            default:
                return "We dont know";
                break;
        }
    }
    
    public static string ServiceParser(int value)
    {
        switch ((ServiceStatusEnum) value)
        {
            case ServiceStatusEnum.Waiting:
                return "Очікує в черзі";
                break;
            case ServiceStatusEnum.Working:
                return "Ведеться робота";
                break;
            case ServiceStatusEnum.OnPause:
                return "Очікування запчастин";
                break;
            default:
                return "Ми не знаємо";
                break;
        }
    }
    
    
}