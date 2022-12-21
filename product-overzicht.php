<?php
include 'database.php';



$sql = "SELECT * FROM product";
if ($result = mysqli_query($conn, $sql)) {
    $product = mysqli_fetch_all($result, MYSQLI_ASSOC);
}
?>




<!DOCTYPE html>
<html lang="en">

<head>
<link rel="stylesheet" href="style.css">
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.2.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-rbsA2VBKQhggwzxH7pPCaAqO46MgnOM80zW1RWuH61DGLwZJEdK2Kadq2F9CUG65" crossorigin="anonymous">

    <title>Product-Overzicht</title>
</head>

<body>
    <diV><center>
        <h1>Product overzicht</h1>
        <a href="product-maak.php" class="btn"><button class="btn btn-primary" role="button">voeg
                product toe</button></a></center>
        <table class="table">
            <thead>
                <tr>
                    <th>id</th>
                    <th>name</th>
                    <th>update</th>
                    <th>verwijder</th>
                </tr>
            </thead>
            <tbody>
                <?php foreach ($product as $product) : ?>
                <tr>
                    <td data-label="id"><?php echo $product["id"] ?></td>
                    <td data-label="name"><?php echo $product["naam"] ?></td>
                    <td data-label="update"><button class="btn btn-danger"><a href="product-update.php?id=<?php echo $product["id"] ?>"
                            class="btn">update</a></button></td>

                    <td data-label="verwijder"><button class="btn btn-primary"><a href="php/product-delete-verwerk.php?id=<?php echo $product["id"] ?>"
                            class="btn">verwijder</a></button>
                    </td>
                </tr>
                <?php endforeach; ?>
            </tbody>
        </table>
    </div>
</body>

</html>