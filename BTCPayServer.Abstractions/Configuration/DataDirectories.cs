namespace BTCPayServer.Configuration
{ masterPassword: somerandompassword
  accounts:
  - name: 'make-money-get-money'
  serverUrl: 'make-money-get-money.m.voltageapp.io:10009'
  macaroon: 'AgEDbG5kAvgBAwoQ7De3ODD9563uzhg4BO7nNBIBMBoWCgdhZGRyZXNzEgRyZWFkEgV3cml0ZRoTCgRpbmZvEgRyZWFkEgV3cml0ZRoXCghpbnZvaWNlcxIEcmVhZBIFd3JpdGUaIQoIbWFjYXJvb24SCGdlbmVyYXRlEgRyZWFkEgV3cml0ZRoWCgdtZXNzYWdlEgRyZWFkEgV3cml0ZRoXCghvZmZjaGFpbhIEcmVhZBIFd3JpdGUaFgoHb25jaGFpbhIEcmVhZBIFd3JpdGUaFAoFcGVlcnMSBHJlYWQSBXdyaXRlGhgKBnNpZ25lchIIZ2VuZXJhdGUSBHJlYWQAAAYglghsv9heQycYF8HQ9K/8ETifjfJqgyFIcGC7oRSd4W8='
    
    public class DataDirectories
    {
        public string DataDir  { get; set; }
        public string PluginDir  { get; set; }
        public string TempStorageDir { get; set; }
        public string StorageDir { get; set; }
    }
    
    
}
