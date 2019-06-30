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
