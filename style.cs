/* Add your responsive styles here */
body {
    font-family: Arial, sans-serif;
}

form {
    width: 80%;
    max-width: 400px;
    margin: auto;
    padding: 20px;
    border: 1px solid #ddd;
}

label, input, button {
    display: block;
    width: 100%;
    margin-bottom: 10px;
}

@media (max-width: 600px) {
    form {
        width: 95%;
    }
}
