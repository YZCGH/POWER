function Run(type)
	local bResult = false;
	local sSvpUpdatePath = "..\\..\\bat\\CVTATSvnUpdate.bat"

	if type == nDeleteUsbFile then
		bResult = delete_file(sUsbDisk .. ":\\*.*");
	elseif type == nSvnUpdate then
		bResult = os.execute("start" .. sSvpUpdatePath);
	end
 
	return bResult;
end
