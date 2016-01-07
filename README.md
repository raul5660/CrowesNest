# CrowesNest
##A productivity/tool deployment platform for Penetration Testers and IT Professionals.
![CrowesNest Overview](CrowesNestScreenshots/2.0/Overview.JPG?raw=true)
##The Problem:
As technical professionals we use literally hundreds of tools to do our job. Majority of these tools are command-line oriented with varying degrees of complexity and arbitrary flags for using the features they support. Some of the tools are Windows based, some Linux based, some tools support multiple targets via input files or subnet logic (eg: nmaps -iL flag), some only support single targets (eg: nc.exe -nv targetIP targetPort). Almost all are slightly unintuitive to new users or at the very least have hard to remember syntax. These problems have pen testers constantly switching between virtual machines, refering to manual pages, refering to help files, refering to the internet, refering to our colleagues, or our own notes just to do a task. This time could be better spent thinking critically, thus providing more value to our clients through additional findings or better reports.

##The Solution: CrowesNest 
This tool alleviates the need to:
* Remember complex syntax for common tasks by configuring tools in its configuration file.
* Remeber tool locations on a system by configuring tools in its configuration file.
* Move back and fourth between two Operating Systems to complete tasks or extract data by supporting SSH connection, SFTP, and remote command execution.
* Refer to many different help materials by keeping user defined notes in one location.
* Managing the overhead of deploying tools by deploying them for you in one-click interaction regardless of system.
* Manage scalability of single target tools by utilizing the CrowesNest scripting engine that supports BASH/BATCH output.
* Managing tool ouput, and ouput syntax by utilizing CrowesNest folder selection feature.

##Configuration and Usage

Initial Setup Steps:

* Download link for WinSCP:https://winscp.net/eng/download.php
* Download link for PuTTY and Plink: http://www.chiark.greenend.org.uk/~sgtatham/putty/download.html

1. Install plinke.exe and PuTTY here: C:\Program Files (x86)\PuTTY\
2. Install WinSCP.exe here: C:\Program Files (x86)\WinSCP\ 
3. Add the following XML to C:\tools\CrowesNest\cn_config.xml and Save:
   Note**: (If you do not create C:\tools\CrowesNest\cn_config.xml manually it will do it for you but you still need to populate cn_config.xml with a valid configuration.)

Additionally you can import configurations during runtime with Configure -> "Select XML File..."

![CrowesNest Overview](CrowesNestScreenshots/2.0/crowesNestXMLNoConfig.JPG?raw=true)

Congrats, thats it! You now have CrowesNest configured without any tools or notes.

Adding Tools:

Adding tools is as easy as just populating the associated XML attributes. Lets configure ping for linux together.

1. Edit C:\tools\CrowesNest\cn_config.xml with the following entry.
![CrowesNest Overview](CrowesNestScreenshots/2.0/crowesNestXMLToolConfig.JPG?raw=true)

Our ping configuration:
* <Name>Ping_Linux</Name> is the name I selected to use.
* <Location>/bin/ping</Location> is the location of the binary or script on the intended system. If the script needs an interpreter please put the interpreter binary here. For example, some_script.py would require the python intepreter to run.
* <Arguments>8.8.8.8</Arguments> are the argument you want for the tool.
* <OperatingSystem>Linux</OperatingSystem> is the intended deployment platform.
* I chose to use the ping man page as our notes.
To add additional tools use the same format.


##Using the Features
###Deploying Tools - The "Run" button.
Deploying the selected tool is as easy as hitting run. 
* If tool is marked "Windows" on the OperatingSystem XML attribute CrowesNest will deploy a local instance in a seperate process from its allocated Virtual Memory. This means that a running tool will not be affected if the CrowesNest applications is terminated.
* If tool is marked "Linux" on the OperatingSystem XML attribute CrowesNest will attempt to connect to the remote machine indicated in the "Remote Connection" section. If no connection details are given, it will ask for them without deploying tool. If connection details are present. CrowesNest will run the tool on the remote machine and give you a shell to monitor.
* It important to note that you can type in the "syntax" text box to ammend commands on the fly. This means you can clear the entire pre-saved syntax and use the textbox like a shell if you please. 
![CrowesNest Overview](CrowesNestScreenshots/crowesNestWindowsPingViewRunning.JPG?raw=true)

###Script Generation - The "Export" button.
Export tools to scripts using the export button.

####Single Host (No Hosts File selected)
* If tool is marked "Windows" on the OperatingSystem XML attribute CrowesNest will export the tool syntax to a runnable .bat script located at C:\tools\CrowesNest\Batch , if directory doesnt exist, it will be created for you.
* If tool is marked "Linux" on the OperatingSystem XML attribute CrowesNest will export the tool syntax to a runnable .sh script located at C:\tools\CrowesNest\Bash , if directory doesnt exist, it will be created for you.
* Scripts will be named with the name of the tool and their appropriate OS extension. 
* If export button is hit more then once for the same tool, the script will be overwritten.
![CrowesNest Overview](CrowesNestScreenshots/crowesNestExportWindows2.JPG?raw=true)

####Multiple Hosts (Hosts File selected)
If a tool does not support multiple hosts nativly, like nmaps -iL option, CrowesNest makes managing single host tools much for flexible by implementing scalability.
* Click the checkbox and select an IP input file with IP address seperated by new line.
![CrowesNest Overview](CrowesNestScreenshots/crowesNestExportWindows.JPG?raw=true)

* When configuring a single host tool, place the string pattern x.x.x.x in the ip location. Any instance of this string pattern will be replaced with the line indicated in the file. With the host file selected, hit export. A script will be generated.
![CrowesNest Overview](CrowesNestScreenshots/crowesNestExportWindows3.JPG?raw=true)

* This engine is very flexible. It will replace any instance of x.x.x.x with anything indicated in the selected hosts file, making it possible to generate scripts of other types, not just IP address. Eg: if the input file had the following text:
crowes
nest
Then any instance of x.x.x.x will be replaced with "crowes" and "nest" and written to a script file.

* You cannot run single instances of tools while multi host file is selected.

####Script File Selected (Cross tool scripting)
CorwesNest now supports script generation capabilities for combining tools. 
* Just check the "Use cross tool scripting" check box and select or create a file youd like to export syntax to. Use .bat extension for batch scripts and .sh extensions for Bash shell scripts.
* Now the export button will append any tool selected to the existing content of that file, allowing you to build workflow scripts with just a few clicks!
* All scripting features mentioned before are supports for cross tool scripting.

###Folder Selection - The "Client Folder" button.
Much like the scalable script generation functionality. CrowesNest allows you to select a directory for command that support output options or for use with standard output redirection.
* When configuring a tool in which you want to use the folder selection feature, add the string pattern "Z:\XYZ" to its syntax.
![CrowesNest Overview](CrowesNestScreenshots/crowesNestClientFolder.JPG?raw=true)

* When selecting a folder, the Z:XYZ patter will be replaced with the directory you chose, much like the x.x.x.x pattern.
![CrowesNest Overview](CrowesNestScreenshots/crowesNestClientFolder2.JPG?raw=true)

![CrowesNest Overview](CrowesNestScreenshots/crowesNestClientFolder3.JPG?raw=true)

* The syntax box wont updated automatically by design. I chose this so every tool thats loaded into CrowesNest will update with the client folder when you select it, so to update the syntax text box, just cick off the tool then back on.

###Using Putty SSH - The "PuTTY" button.
CrowesNest will launch a SSH shell with a single click! Allowing you remote interaction.
* If no connection details are given, it will ask for them. If connection details are present. CrowesNest will launch a remote shell.
![CrowesNest Overview](CrowesNestScreenshots/crowesNestPuttyIntegration.JPG?raw=true)

* This shell is a seperated process same as tools that are deployed, closing crowesNest will not effect the shell.

###Using WinSCP SFTP - The "WinSCP" Button
CrowesNest will launch a WinSCP commander with a single click! Allowing you to move files back and forth on the fly.
* If no connection details are given, it will ask for them. If connection details are present. CrowesNest will launch a remote shell.
![CrowesNest Overview](CrowesNestScreenshots/crowesNestWinSCPIntegration.JPG?raw=true)

* This session is a seperated process same as tools that are deployed, closing crowesNest will not effect the shell.

##Dependencies

### Binary applications in these exact locations:
* C:\Program Files (x86)\PuTTY\plink.exe
* C:\Program Files (x86)\PuTTY\putty.exe
* C:\Program Files (x86)\WinSCP\WinSCP.exe


