# CrowesNest
##A productivity/tool deployment platform for Penetration Testers and IT Professionals.
![CrowesNest Overview](CrowesNestScreenshots/crowesNestOverview.JPG?raw=true)
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
CrowesNest has a few hardcoded dependencies (I know this is not ideal but hey, I do this in my freetime.)

Initial Setup Steps:

* Download link for WinSCP:https://winscp.net/eng/download.php
* Download link for PuTTY and Plink: http://www.chiark.greenend.org.uk/~sgtatham/putty/download.html

1. Install plinke.exe and PuTTY here: C:\Program Files (x86)\PuTTY\
2. Install WinSCP.exe here: C:\Program Files (x86)\WinSCP\ 
3. Add the following XML to C:\tools\CrowesNest\cn_config.xml and Save:

![CrowesNest Overview](CrowesNestScreenshots/crowesNestXMLNoConfig.JPG?raw=true)

Congrats, thats it! You now have CrowesNest configured without any tools or notes.

Adding Tools:

Adding tools is as easy as just populating the associated XML attributes. Lets configure ping for linux together.

1. Edit C:\tools\CrowesNest\cn_config.xml with the following entry.
![CrowesNest Overview](CrowesNestScreenshots/crowesNestXMLToolConfig.JPG?raw=true)

Our ping configuration:
* <Name>Ping_Linux</Name> is the name I selected to use.
* <Location>/bin/ping</Location> is the location of the binary or script on the intended system. If the script needs an interpreter please put the interpreter binary here. For example, some_script.py would require the python intepreter to run.
* <Arguments>8.8.8.8</Arguments> are the argument you want for the tool.
* <OperatingSystem>Linux</OperatingSystem> is the intended deployment platform.
* I chose to use the ping man page as our notes.
To add additional tools use the same format.

//More usage info coming for configuring and using features.
##Using the Features
###Script Generation
###Folder Selection
###Using Putty SSH
###Using WinSCP SFTP
###Using Remote Command Execution

##Dependencies

### Binary applications in these exact locations:
* C:\Program Files (x86)\PuTTY\plink.exe
* C:\Program Files (x86)\PuTTY\putty.exe
* C:\Program Files (x86)\WinSCP\WinSCP.exe


