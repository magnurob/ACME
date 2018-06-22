;#DropDB ACMEEasyTest

#Application ACME.Win
#Application ACME.Web
#IfDef ACME.Win

*Action About...
 
*Action OK

#EndIf

#IfDef ACME.Web
!Action Navigation(My Details)
#EndIf
