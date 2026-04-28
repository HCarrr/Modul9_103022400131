using System;

public class BankTransferConfig
{
	public Transfer transfer {  get; set; }
	public Confirmation confirmation { get; set; }
    public string lang { get; set; }
	public string method { get; set; }
	

	class Transfer()
	{
        public double threshold { get; set; }
        public double low_fee { get; set; }
        public int high_fee { get; set; }
        
	}

	class Confirmation()
	{
		public string en {  get; set; }
		public string id { get; set; }
	}

	public BankTransferConfig()
	{}
	public static BankTransferConfig LoadConfig()
	{
        BankTransferConfig defaultConfig = new BankTransferConfig
		{
			thresshold 
		}

    }

}

class 
