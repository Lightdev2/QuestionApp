<template>
  <div class="user">
    <div class="user__header">
      <div class="user__avatar">J</div>
      <div class="user__header-content">
        <span class="user__header-name">Jhon Doe</span>
        <span>
          <cake class="user__header-cake" />Member for 3 years 1 month
        </span>
      </div>
    </div>
    <div class="user__body">
      <div class="user__body-left">
        <h3 class="user__stats-title">Statistics</h3>
        <content-block :head="false">
          <template #body>
            <div class="user__stats-body">
              <div class="user__stats-stat">27<br/>reputation</div>
              <div class="user__stats-stat">200<br/>messages</div>
              <div class="user__stats-stat">1<br/>asnwer</div>
              <div class="user__stats-stat">11<br/>questions</div>
            </div>
          </template>
        </content-block>
      </div>
      <div class="user__body-right">
        <div>
          <h3>Achievements</h3>
          <content-block :head="false">
            <template #body>
              <span>No achievements yet</span>
            </template>
          </content-block>
        </div>
        <div>
          <div>
            <h3>New Messages</h3>
            <div>
              <tabs-component :tabs="messageTypes" />
              <tabs-component :tabs="sortModes" />
            </div>
          </div>
          <content-block :head="false">
            <template #body>
              <span>No messages yet</span>
            </template>
          </content-block>
        </div>
      </div>
    </div>
  </div>
</template>

<script>
import Cake from "@/assets/cake.vue";
import ContentBlock from "@/components/ContentBlock";
import TabsComponent from "@/components/TabsComponent";
export default {
  name: "User",
  components: {
    Cake,
    ContentBlock,
    TabsComponent,
  },
};
</script>

<script setup>
const sortModes = ["Rating", "New"];
const messageTypes = ["All", "Questions", "Answers"];
</script>

<style scoped lang="scss">
.user {
  margin-left: 10px;
  &__avatar {
    display: flex;
    align-items: center;
    justify-content: center;
    width: 128px;
    height: 128px;
    background-color: red;
  }
  &__header {
    display: flex;
    align-items: center;
  }
  &__header-name {
    color: var(--black900);
    margin-bottom: 0.5rem;
    font-size: 24px;
  }
  &__header-cake {
    margin-right: 0.3rem;
  }
  &__header-content {
    display: flex;
    flex-direction: column;
    color: var(--black700);
    fill: var(--black700);
    margin-left: 1rem;
  }
  &__body {
    display: flex;
  }
  &__body-right {
    flex-grow: 1;
  }
  &__body-left {
    min-width: 250px;
    max-width: 250px;
    margin-right: 1rem;
  }
  &__stats-title {
    color: var(--black700);
    font-weight: 500;
  }
  &__stats-body {
    display: grid;
    grid-template-columns: repeat(2, 1fr);
    grid-template-rows: repeat(2, 1fr);
  }
  &__stats-stat {
    color: var(--black700);
    display: block;
    padding: 10px 0;
    white-space: pre;
  }
}
</style>
