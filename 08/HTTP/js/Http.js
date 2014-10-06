// JScript 文件
function CreateHttpRequest() {

        var arrSignatures = ["MSXML2.XMLHTTP.5.0", "MSXML2.XMLHTTP.4.0",
                             "MSXML2.XMLHTTP.3.0", "MSXML2.XMLHTTP",
                             "Microsoft.XMLHTTP"];
                         
        for (var i=0; i < arrSignatures.length; i++) {
            try {
        
                var oRequest = new ActiveXObject(arrSignatures[i]);
            
                return oRequest;
        
            } catch (oError) {
                //ignore
            }
        }          

        throw new Error("MSXML is not installed on your system.");               
    }
    
 var Http = new Object();
 //3个参数 url  ajax正在处理的函数，成功返回的函数
 Http.Get=function(url,fnLoading,fnCallBack)
 {
     var oRequest = CreateHttpRequest();
     if (oRequest){
        oRequest.open("get",url,true);
        oRequest.onreadystatechange = function()
        {
             if (oRequest.readyState == 4)
             {
                 if (fnCallBack) fnCallBack(oRequest.responseText);
             }else
             {
                if (fnLoading) fnLoading();
             }
        }
        
        oRequest.send(null);

     }
 }


