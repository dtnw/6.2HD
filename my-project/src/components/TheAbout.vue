<script setup>
import AboutItem from './AboutItem.vue'
import ToolingIcon from './icons/IconTooling.vue'
import EcosystemIcon from './icons/IconEcosystem.vue'
import CommunityIcon from './icons/IconCommunity.vue'
</script>

<template>

  <AboutItem>
    <template #icon>
      <ToolingIcon />
    </template>
    
    <template #heading>Build</template>

    To build my <a href="https://vuejs.org/" target="_blank" rel="noopener">Vue</a> web application, I employ <a href="https://www.jenkins.io/" target="_blank" rel="noopener">Jenkins</a> 
    piepeline to ensure a smooth and automated process.
    The pipeline stages included cloning the repository from <a href="https://github.com/" target="_blank" rel="noopener">GitHub</a>, and then the build stage used npm to install dependencies and compile the Vue web app.
      </AboutItem>

  <AboutItem>
    <template #icon>
      <EcosystemIcon />
    </template>
    
    <template #heading>Test</template>

    For testing, I integrated <a href="https://www.selenium.dev/" target="_blank" rel="noopener">Selenium</a>
    for automated testing into the pipeline.
    It conducts end-to-end testing by mimicing user interactions with the application in a real browser environment.
    These tests ensures that the application behvaes as expected under various scenarios.
    These tests are set to run automatically after the build stage to provide immediate feedback on the stablity and functionality of the applicaiton.
      </AboutItem>

  <AboutItem>
    <template #icon>
      <CommunityIcon />
    </template>
    <template #heading>Deploy</template>
    In this stage, I utilized FTP to transfer the built application to <a href="https://www.000webhost.com/" target="_blank" rel="noopener">000webhost.com</a>, a free hosting service.
    I configured Jenkins to use the <a href="https://plugins.jenkins.io/publish-over-ftp/" target="_blank" rel="noopener">Publish over FTP</a> plugin to transfer the files from the `dist` directory into the `public_html` directory on the web host.
    This deployment simulated a production setting that thoroughly tests and verifies the reliability and performance of the web app before going live.
    This automated process ensures a consistent deployment that minimizes downtime and risk of errors.

  </AboutItem>
</template>
