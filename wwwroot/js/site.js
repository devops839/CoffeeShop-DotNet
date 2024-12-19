// Global variable to hold cart items
let cart = [];

// Function to add items to the cart
function addToCart(itemName) {
    // Check if the item is already in the cart
    let item = cart.find(item => item.name === itemName);

    if (item) {
        // If the item already exists in the cart, increase the quantity
        item.quantity++;
    } else {
        // If the item does not exist in the cart, add it with quantity 1
        let price = getPrice(itemName);
        cart.push({
            name: itemName,
            price: price,
            quantity: 1
        });
    }

    // Update the cart display after adding the item
    updateCartDisplay();
}

// Function to get the price of the coffee based on its name
function getPrice(itemName) {
    const prices = {
        'Espresso': 3.50,
        'Cappuccino': 4.00,
        'Iced Coffee': 4.50,
        'Americano': 3.00,
        'Latte': 4.50,
        'Mocha': 5.00
    };
    return prices[itemName] || 0;
}

// Function to update the cart display
function updateCartDisplay() {
    let cartDisplay = document.getElementById('cart-display');
    let total = 0;

    // Clear previous cart display
    cartDisplay.innerHTML = '';

    // If there are no items in the cart, do not show the cart section
    if (cart.length === 0) {
        return;
    }

    // Display the cart heading
    cartDisplay.innerHTML += '<h3>Your Cart</h3>';

    // Display cart items
    cart.forEach(item => {
        let itemTotal = item.price * item.quantity;
        total += itemTotal;
        cartDisplay.innerHTML += `
            <div>
                ${item.quantity} x ${item.name} - $${itemTotal.toFixed(2)}
                <br>
            </div>
        `;
    });

    // Display the total price
    cartDisplay.innerHTML += `<div><strong>Total: $${total.toFixed(2)}</strong></div>`;

    // Display "Order Now" button if cart is not empty
    if (cart.length > 0) {
        cartDisplay.innerHTML += `
            <button id="order-now-btn" onclick="showOrderForm()" class="order-btn">Order Now</button>
        `;
    }
}

// Function to show the order form
function showOrderForm() {
    // Ask for the user's name
    let userName = prompt('Please enter your name:');

    // If the user did not enter a name, return
    if (!userName) {
        alert('Name is required!');
        return;
    }

    // Calculate total amount
    let totalAmount = calculateTotalAmount();

    // Display the confirmation message with the user's name, items, and total amount
    let orderSummary = `Thank you for your order, ${userName}!\n\nYour order:\n`;

    cart.forEach(item => {
        orderSummary += `${item.quantity} x ${item.name}\n`;
    });

    orderSummary += `\nTotal Amount: $${totalAmount.toFixed(2)}`;

    // Show the order confirmation in a prompt or alert
    alert(orderSummary);

    // Clear the cart after the order is placed
    cart = [];

    // Update the cart display
    updateCartDisplay();
}

// Function to calculate the total amount of the cart
function calculateTotalAmount() {
    return cart.reduce((total, item) => total + (item.price * item.quantity), 0);
}
