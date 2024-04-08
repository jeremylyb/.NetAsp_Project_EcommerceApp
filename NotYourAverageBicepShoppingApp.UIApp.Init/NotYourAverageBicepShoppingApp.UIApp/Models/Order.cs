﻿using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace NotYourAverageBicepShoppingApp.UIApp.Models;

public partial class Order
{
    [JsonPropertyName("orderId")]
    public int OrderId { get; set; }

    [JsonPropertyName("customerName")]
    public string CustomerName { get; set; } = null!;

    [JsonPropertyName("cartId")]
    public int CartId { get; set; }
}