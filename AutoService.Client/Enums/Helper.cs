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
                return "Waiting in queue";
                break;
            case ServiceStatusEnum.Working:
                return "Working on";
                break;
            case ServiceStatusEnum.OnPause:
                return "Waiting parts";
                break;
            default:
                return "We dont know";
                break;
        }
    }
    
    
}