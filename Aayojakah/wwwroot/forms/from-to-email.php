<?php
if(isset($_POST['contact_btn'])){
	$name = $_POST['name'];
	$email = $_POST['email'];
	$subject = $_POST['subject'];
	$message = $_POST['message'];
	$to = "anandkalpe18@gmail.com";
	$header = "from:$email";

	
	if(mail($to,$subject,$message,$header)){
		$msg1 = "Message sent successfully";
	}
}
?>







