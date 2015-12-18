# CrowesNest
##A productivity/tool deployment platform for Penetration Testers and IT Professionals.
![CrowesNest Overview](CrowesNestScreenshots/crowesNestOverview.JPG?raw=true)
##Description
As technical professionals we use literally hundreds of tools to do our job. Majority of these tools are command-line oriented with varying degrees of complexity and arbitrary flags for using the features they support. Some of the tools are Windows based, some Linux based, some tools support multiple targets via input files or subnet logic (eg: nmaps -iL flag), some only support single targets (eg: nc.exe -nv targetIP targetPort). Almost all are slightly unintuitive to new users or at the very least have hard to remember syntax. These problems have pen testers constantly switching between virtual machines, refering to manual pages, refering to help files, refering to the internet, refering to our colleagues, or our own notes just to do a task. This time could be better spent thinking critically, thus providing more value to our clients through additional findings or better reports.

#Insert CrowesNest 
This tool alleviates the need to:
* Remember complex syntax for common tasks by configuring tools in its configuration file.
* Remeber tool locations on a system by configuring tools in its configuration file.
* Move back and fourth between two Operating Systems to complete tasks or extract data by supporting SSH connection, SFTP, and remote command execution.
* Refer to many different help materials by keeping user defined notes in one location.
* Managing the overhead of deploying tools by deploying them for you in one-click interaction regardless of system.
* Manage scalability of single target tools by utilizing the CrowesNest scripting engine that supports BASH/BATCH output.
* Managing tool ouput, and ouput syntax by utilizing CrowesNest folder selection feature.

##Configuration and Usage
//Screenshots and explanations coming soon...



##Dependencies

### Binary applications in these exact locations:
* C:\Program Files (x86)\plink\plink.exe
* C:\Program Files (x86)\PuTTY\putty.exe
* C:\Program Files (x86)\WinSCP\WinSCP.exe

###Directories:
* C:\tools\CrowesNest\Bash
* C:\tools\CrowesNest\Batch

###Files:
* C:\tools\CrowesNest\Batch\cn_config.xml

