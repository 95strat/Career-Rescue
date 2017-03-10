<?php
if($_POST["message"]) {
    mail("admin@kosloskiprojects.com", "Form to email message", $_POST["contact_message"], "From: an@email.address");
}
?>

<!DOCTYPE html>
<html>
<head>
    <title></title>
	<meta charset="utf-8" />
</head>
<body>

</body>
</html>
