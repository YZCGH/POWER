function Run(type)
	local bResult = false;
	local sOrgPath = "..\\..\\bat\\"
	local sSvpUpdatePath = sOrgPath .. "CVTATSvnUpdate.bat"
	local sComputerIpPath = sOrgPath .. "DVBSConnect.bat"

	if type == nDeleteUsbFile then
		bResult = delete_file(sUsbDisk .. ":\\*.*");
	elseif type == nSvnUpdate then
		bResult = os.execute("start" .. sSvpUpdatePath);
	elseif type == nIpConnect then
		bResult = os.execute("start" .. sComputerIpPath);
	end
 
	return bResult;
end
