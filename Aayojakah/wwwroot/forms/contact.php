<?php
if(!isset($_POST['submit']))
{
	echo"error;you need to submit the form!";

}
$name = $_POST['name'];
$visitor_email