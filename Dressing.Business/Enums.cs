namespace Dressing.Business
{
    /// <summary>
    /// To improve readability, this enum is added. To support new Temperature Type, new value needs to be added in this enum.
    /// </summary>
    public enum TemperatureType
    {
        HOT = 1,
        COLD = 2
    }
    /// <summary>
    /// To improve readability, this enum is added. To support new command, new value needs to be added in this enum.
    /// </summary>
    public enum CommandType
    {
        PUT_FOOT_WEAR = 1,
        PUT_HEAD_WEAR = 2,
        PUT_SOCKS = 3,
        PUT_SHIRT = 4,
        PUT_JACKET = 5,
        PUT_PANTS = 6,
        LEAVE_HOUSE = 7,
        TAKE_OFF_PAJAMAS = 8
    }
  
}
