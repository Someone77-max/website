<%@ Page Language="C#" MasterPageFile="../MasterPage.Master" %> 
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
  
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

<form id="password-recovery" method="get">
<label>Username</label><br />
<input><br />

<label>Password Recovery Questions</label><br />
<select multiple>
<option value="Cat's Name">Cat's Name</option>
<option value="Grandma's Name">Grandma's Name</option>
<option value="Mom's Name">Mom's Name</option>
<option value="Dad's Name">Dad's Name</option>
</select><br />
<input><br />
<input><br />

<input type="submit">
</asp:Content>
