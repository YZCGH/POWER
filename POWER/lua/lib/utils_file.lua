function delete_file(sFilePath)
    local bRet = false;

    if(os.execute(("del /Q /F \"%s\""):format(sFilePath)) == 0) then
        bRet = true;
    end

    return bRet;
end
