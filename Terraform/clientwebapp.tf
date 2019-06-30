terraform {
  backend "azurerm" {
    storage_account_name = "__terraformstorageaccount__"
    container_name       = "__terraformcontainer__"
    key                  = "terraform.tfstate"
    access_key           = "__storagekey__"
  }
}

provider "azurerm" {
  
}

resource "azurerm_resource_group" "devops_portal" {
  name = "gw-devops-portal-rg"
  location = "West Europe"

  tags = {
      product = "devops portal",
      organisation = "GammaWeb Solutions"
  }
}

resource "azurerm_app_service_plan" "devops_portal" {
  name = "gw-devops-portal-serviceplan"
  location = "${azurerm_resource_group.devops_portal.location}"
  resource_group_name = "${azurerm_resource_group.devops_portal.name}"
  kind = "Linux"
  reserved = true

  sku = {
    tier = "Free",
    size = "F1"
  }

  tags = {
    product = "devops portal",
      organisation = "GammaWeb Solutions"
  }
}
