terraform {
  backend "azurerm" {
    storage_account_name = "__terraformstorageaccount__"
    container_name       = "__terraformcontainer__"
    key                  = "terraform.tfstate"
    access_key           = "__storagekey__"
  }
}

variable "product" {
  default = "devops portal"
}

variable "organisation" {
  default = "GammaWeb Solutions"
}

provider "azurerm" {
  
}

resource "azurerm_resource_group" "devops_portal" {
  name = "gw-devops-portal-rg"
  location = "West Europe"

  tags = {
      product = "${var.product}",
      organisation = "${var.organisation}"
  }
}

resource "azurerm_app_service_plan" "devops_portal" {
  name = "gw-devops-portal-serviceplan"
  location = "${azurerm_resource_group.devops_portal.location}"
  resource_group_name = "${azurerm_resource_group.devops_portal.name}"

  sku {
    tier = "Free"
    size = "F1"
  }

  tags = {
      product = "${var.product}",
      organisation = "${var.organisation}"
  }
}

resource "azurerm_app_service" "devops_portal_client" {
  name = "gw-devops-portal-client"
  location = "${azurerm_resource_group.devops_portal.location}"
  resource_group_name = "${azurerm_resource_group.devops_portal.name}"
  app_service_plan_id = "${azurerm_app_service_plan.devops_portal.id}"
  https_only = true

  tags = {
      product = "${var.product}",
      organisation = "${var.organisation}"
  }
}

resource "azurerm_app_service" "devops_portal_api" {
  name = "gw-devops-portal-api"
  location = "${azurerm_resource_group.devops_portal.location}"
  resource_group_name = "${azurerm_resource_group.devops_portal.name}"
  app_service_plan_id = "${azurerm_app_service_plan.devops_portal.id}"
  https_only = true

  tags = {
      product = "${var.product}",
      organisation = "${var.organisation}"
  }
}