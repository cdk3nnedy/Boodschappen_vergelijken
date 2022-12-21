<?php

require 'database.php';
if (isset($_POST["submit"])) {
    $id = $_POST["id"];


    if (
        !empty($_POST["name"])
        && !empty($_POST["priceperkg"])
        && !empty($_POST["flavorotweek"])
        && !empty($_POST["category"])
        && !empty($_POST["picture"])
        && !empty($_POST["description"])

    ) {

        $name = $_POST["name"];
        $priceperkg = $_POST["priceperkg"];
        $flavorotweek = $_POST["flavorotweek"];
        $category = $_POST["category"];
        $picture = $_POST["picture"];
        $description = $_POST["description"];

        $sql = "UPDATE `products` SET 
        `name`='$name',
        `price_per_kg`='$priceperkg',
        `is_flavor_ot_week`='$flavorotweek',
        `category`='$category',
        `picture`='$picture',
        `description`='$description'
       
         WHERE id = '$id'";



        if (mysqli_query($conn, $sql)) {
            header("location: http://localhost/deroset/product-overzicht.php");
        }

        //echo "Inserted successfully";
        mysqli_close($conn);
    } else {
        header("location: http://localhost/deroset/product-update.php?id=$id");
    }
}