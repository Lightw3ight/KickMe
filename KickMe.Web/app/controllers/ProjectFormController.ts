module app {
	'use strict';

	class ProjectFormController {
		constructor(private $modalInstance: ng.ui.bootstrap.IModalServiceInstance, private projectService: IProjectService) {
			//
		}

		ok() {
			this.$modalInstance.close();
		}

		cancel() {
			this.$modalInstance.dismiss();
		}
	}

	angular.module('app')
		.controller('ProjectFormController', ProjectFormController);
}
